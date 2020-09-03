using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class Connection
    {
        private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BookShop.mdb;";

        protected OleDbConnection myConnection = new OleDbConnection(connectString);
    }
}
