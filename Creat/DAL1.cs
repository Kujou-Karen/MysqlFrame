using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat
{
    public class DAL1
    {

        public  void CreatDAL(string tableName, DataTable dt, string dir)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using Model;");
            sb.AppendLine("using System.Data.SqlClient;");
            sb.AppendLine("using System.Data;");
            sb.AppendLine("namespace DAL");
            sb.AppendLine("{");
            sb.AppendLine("class " + tableName + "DAL");
            sb.AppendLine("{");
            sb.AppendLine("    private static MySqlHelper MySqlHelpers = new MySqlHelper();");
            sb.AppendLine("    public int Addnew(" + tableName + " model)");
            sb.AppendLine("{");

            List<String> cols = new List<string>();
            List<String> parameters = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string col = Convert.ToString(row["COLUMN_NAME"]);
                string parameter = "";
                if (col.ToLower() != "id")
                {
                    parameter = "@" + Convert.ToString(row["COLUMN_NAME"]);
                    cols.Add(col);
                    parameters.Add(parameter);
                }
                //parameters.Add(parameter)放外面加上一个NULL，所以会多出一个逗号
                // parameters.Add(parameter);

            }

            sb.AppendLine("string sql = \"insert into " + tableName + "(" + String.Join(",", cols) + ") output inserted.Id values(" + String.Join(",", parameters) + ")\";");
            sb.AppendLine("object obj= MySqlHelpers.ExecuteScalar(sql");

            foreach (DataRow row in dt.Rows)
            {
                string col = Convert.ToString(row["COLUMN_NAME"]);
                if (col.ToLower() != "id")
                {
                    sb.AppendLine(",new SqlParameter(\"" + col + "\",model." + col + ")");
                }

            }
            sb.AppendLine(");");
            sb.AppendLine("return Convert.ToInt32(obj);");
            sb.AppendLine("}");
            //Delete方法

            sb.AppendLine("   public int Delete(int id)");
            sb.AppendLine("{");
            sb.AppendLine(" string sql = \"delete from " + tableName + " where Id=@Id\";");
            sb.AppendLine("return MySqlHelpers.ExecuteNonQuery(sql,new SqlParameter(\"Id\",id));");
            sb.AppendLine("}");

            //Update方法
            sb.AppendLine("public int Update(" + tableName + " model)");
            sb.AppendLine("{");
            string[] uParams1 = (from col in cols select col + "=@" + col).ToArray();

            sb.AppendLine(" string sql = \"update " + tableName + " set " + String.Join(",", uParams1) + " where Id=@Id\";");

            string[] uParams2 = (from col in cols select "new SqlParameter(\"" + col + "\",model." + col + ")").ToArray();
            sb.AppendLine("  return MySqlHelpers.ExecuteNonQuery(sql, " + String.Join(",", uParams2) + " ,new SqlParameter(\"Id\",model.Id));");
            sb.AppendLine("}");

            //GetId方法
            sb.AppendLine(" public " + tableName + " Get(int id)");
            sb.AppendLine("{");
            sb.AppendLine("string sql=\"select * from " + tableName + " where Id=@Id\";");
            sb.AppendLine(" DataTable dt=MySqlHelpers.ExecuteDataTable(sql,new SqlParameter(\"Id\",id));");
            sb.AppendLine("if (dt.Rows.Count<=0)");
            sb.AppendLine("{");
            sb.AppendLine(" return null;");
            sb.AppendLine("}");
            sb.AppendLine("    else if (dt.Rows.Count==1)");
            sb.AppendLine("{");
            sb.AppendLine("" + tableName + " model1 = new " + tableName + "();");
            foreach (DataRow row in dt.Rows)
            {
                string col = Convert.ToString(row["COLUMN_NAME"]);
                string dataType = Convert.ToString(row["data_TYPe"]);
                sb.AppendLine("model1." + col + " = Convert." + tools.Get1(tools.GetType(dataType).ToString()) + "(dt.Rows[0][\"" + col + "\"]);");

            }
            sb.AppendLine("return model1;");
            sb.AppendLine("}");
            sb.AppendLine("else");
            sb.AppendLine("{");
            sb.AppendLine("  throw new Exception(\"数据库中有两条及以上重复数据\");");
            sb.AppendLine("}");
            sb.AppendLine("}");

            //IEnumerable()方法
            sb.AppendLine(" public IEnumerable<" + tableName + "> GetAll()");
            sb.AppendLine("{");
            sb.AppendLine("  string sql = \"select * from " + tableName + "\";");
            sb.AppendLine("DataTable dt = MySqlHelpers.ExecuteDataTable(sql);");
            sb.AppendLine("       List<" + tableName + "> list = new List<" + tableName + ">();");
            sb.AppendLine(" foreach (DataRow row in dt.Rows)");
            sb.AppendLine("{");
            sb.AppendLine("" + tableName + " model = new " + tableName + "();");
            foreach (DataRow row in dt.Rows)
            {
                string col = Convert.ToString(row["COLUMN_NAME"]);
                string dataType = Convert.ToString(row["data_TYPE"]);
                sb.AppendLine("model." + col + " = Convert." + tools.Get1(tools.GetType(dataType).ToString()) + "(row[\"" + col + "\"]);");

            }
            sb.AppendLine("  list.Add(model);");
            sb.AppendLine("}");
            sb.AppendLine("return list;");
            sb.AppendLine("}");
            sb.AppendLine("}");
            sb.AppendLine("}");
            //File.WriteAllText(@"d:\" + tableName + "DAL.cs", sb.ToString());
            tools.WriteToModelFolderDAL(dir, tableName, sb);
        }

    }
}
