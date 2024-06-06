using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class sqlcon
    {   
            public string ServerIp { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string SelectedDatabase { get; set; }

            public sqlcon(string serverIp, string username, string password, string selectedDatabase)
            {
                ServerIp = serverIp;
                Username = username;
                Password = password;
                SelectedDatabase = selectedDatabase;
            }
        

    }
}
