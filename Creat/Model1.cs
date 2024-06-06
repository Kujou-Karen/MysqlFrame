using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat
{
    public class Model1
    {

        public  void CreatModel(string tableName, DataTable dt,string dir)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Data;");
            sb.AppendLine("namespace Model");
            sb.AppendLine("{");
            sb.AppendLine("");
            sb.AppendLine("class " + tableName);
            sb.AppendLine("{");

            foreach (DataRow row in dt.Rows)
            {
                string dataType = Convert.ToString(row["Type"]);

                string columnName = Convert.ToString(row["Field"]);

                sb.AppendLine("public " + tools.GetType(dataType) + " " + columnName + " { get;set;}");
            }
            sb.AppendLine("}");
            sb.AppendLine("}");
            // File.WriteAllText(@"d:\" + tableName + ".cs", sb.ToString());
            tools.WriteToModelFolderModel(dir, tableName, sb);

        }

    }
}
