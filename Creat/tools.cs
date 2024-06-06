using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat
{
    public class tools
    {

        public static string Get1(string dataType)
        {

            switch (dataType.ToLower())
            {
                case "string":
                    return "ToString";
                case "int32":
                    return "ToInt32";
                case "int64":
                    return "ToInt64";
                case "datetime":
                    return "ToDateTime";
                case "boolean":
                    return "ToBoolean";

                default:
                    throw new Exception("找不到匹配的数据类型");

            }
        }


        public static string GetType(string dataType)
        {
            // 处理数据类型字符串，只保留基本类型部分
            if (dataType.Contains("("))
            {
                dataType = dataType.Substring(0, dataType.IndexOf("("));
            }

            switch (dataType.ToLower())
            {
                case "nvarchar":
                case "varchar":
                case "nchar":
                case "char":
                    return typeof(string).Name;
                case "int":
                    return typeof(int).Name;
                case "bigint":
                    return typeof(long).Name;
                case "bit":
                    return typeof(bool).Name;
                case "datetime":
                    return typeof(DateTime).Name;
                default:
                    return typeof(object).Name;
            }
        }

        public static void WriteToModelFolderModel(string dir, string tableName, StringBuilder sb)
        {
            string modelFolderPath = Path.Combine(dir, "Model");
            if (!Directory.Exists(modelFolderPath))
            {
                Directory.CreateDirectory(modelFolderPath);
            }

            string filePath = Path.Combine(modelFolderPath, tableName + ".cs");
            File.WriteAllText(filePath, sb.ToString());
        }

        public static void WriteToModelFolderDAL(string dir, string tableName, StringBuilder sb)
        {
            string modelFolderPath = Path.Combine(dir, "DAL");
            if (!Directory.Exists(modelFolderPath))
            {
                Directory.CreateDirectory(modelFolderPath);
            }

            string filePath = Path.Combine(modelFolderPath, tableName + ".cs");
            File.WriteAllText(filePath, sb.ToString());
        }

        public static void WriteToModelFolderBLL(string dir, string tableName, StringBuilder sb)
        {
            string modelFolderPath = Path.Combine(dir, "BLL");
            if (!Directory.Exists(modelFolderPath))
            {
                Directory.CreateDirectory(modelFolderPath);
            }

            string filePath = Path.Combine(modelFolderPath, tableName + ".cs");
            File.WriteAllText(filePath, sb.ToString());
        }
        public static void WriteToModelFolderDALHelper(string dir, string tableName, StringBuilder sb)
        {
            string modelFolderPath = Path.Combine(dir, "DAL");
            if (!Directory.Exists(modelFolderPath))
            {
                Directory.CreateDirectory(modelFolderPath);
            }

            string filePath = Path.Combine(modelFolderPath, tableName + ".cs");
            File.WriteAllText(filePath, sb.ToString());
        }


    }

}

