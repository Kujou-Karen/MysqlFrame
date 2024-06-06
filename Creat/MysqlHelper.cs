using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creat
{
    public class MysqlHelper
    {

        public bool CreatMYSQLHelper(sqlcon sqlcon, string dir)
        {
            string filePath = Path.Combine(dir, "DAL/MysqlHelper.cs");

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                fileContent = fileContent.Replace("server=127.0.0.1;database=demo;username=root;password=111111;", $"server={sqlcon.ServerIp};database={sqlcon.SelectedDatabase};username={sqlcon.Username};password={sqlcon.Password};");
                File.WriteAllText(filePath, fileContent);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
