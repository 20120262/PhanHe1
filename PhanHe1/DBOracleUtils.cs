﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ATBMHTTT.Connection
{
    class DBOracleUtils
    {
        OracleConnection conn =null;
        public static OracleConnection
                       GetDBConnection(string host, int port, String sid, String user, String password)
        {

            Console.WriteLine("Getting Connection ...");

            // 'Connection String' kết nối trực tiếp tới Oracle.

            string connString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = "
                            + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                            + sid + "))); Password =" + password + "; User ID = " + user;

            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }


    }
}
