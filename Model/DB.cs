using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DB
    {
        public string ServerIp { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> DatabaseNames { get; set; }
        public Dictionary<string, List<string>> TablesInDatabases { get; set; }
    }
}
