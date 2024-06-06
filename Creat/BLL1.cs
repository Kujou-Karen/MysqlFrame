using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat
{
    public class BLL1
    {

        public  void CreatBLL(string tableName, DataTable dt ,string dir)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using  Model;");
            sb.AppendLine("using DAL;");
            sb.AppendLine("using System.Data.SqlClient;");
            sb.AppendLine("using System.Data;");
            sb.AppendLine("namespace BLL");
            sb.AppendLine("{");
            sb.AppendLine("class " + tableName + "BLL");
            sb.AppendLine("{");
            sb.AppendLine("public int Addnew(" + tableName + " model)");
            sb.AppendLine("{");
            sb.AppendLine(" return new " + tableName + "DAL().Addnew(model);");
            sb.AppendLine("}");
            sb.AppendLine("   public int Delete(int id)");
            sb.AppendLine("{");
            sb.AppendLine(" return new " + tableName + "DAL().Delete(id);");
            sb.AppendLine("}");
            sb.AppendLine(" public int Update(" + tableName + " model)");
            sb.AppendLine("{");
            sb.AppendLine(" return new " + tableName + "DAL().Update(model);");
            sb.AppendLine("}");
            sb.AppendLine(" public " + tableName + " Get(int id)");
            sb.AppendLine("{");
            sb.AppendLine(" return new " + tableName + "DAL().Get(id);");
            sb.AppendLine("}");
            sb.AppendLine(" public IEnumerable<" + tableName + "> GetAll()");
            sb.AppendLine("{");
            sb.AppendLine("  return new " + tableName + "DAL().GetAll();");
            sb.AppendLine("}");
            sb.AppendLine("}");
            sb.AppendLine("}");
            tools.WriteToModelFolderBLL(dir, tableName, sb);
        }
    }

}

