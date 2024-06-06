using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class DBHandle
    {
        private DBManager dbManager;

        public DBHandle(string serverIp, string username, string password)
        {
            dbManager = new DBManager(serverIp, username, password);
        }



        public void ProcessDBModel(DB dbModel)
        {
            dbModel.DatabaseNames = dbManager.GetDatabaseNames();
            dbModel.TablesInDatabases = dbManager.GetTablesInDatabases(dbModel.DatabaseNames);
        }

        public DataTable ColumnsInData(string databasename, string tablename)
        {
            return dbManager.GetColumnsInTable(databasename, tablename);
        }
    }
}
