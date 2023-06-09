﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace PhanHe1.Class
{

    class DBUtils
    {
        public static OracleConnection Con;  //Khai báo đối tượng kết nối


        public static bool Connect(string username, string password)
        {
            string host = "192.168.0.27";
            string port = "1521";
            string sid = "XE";

            string strConn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
            + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
            + sid + ")));Password=" + password + ";User ID=" + username + ";DBA Privilege = SYSDBA";


            Con = new OracleConnection(strConn);

            try
            {
                if (Con == null)
                {
                    Con = new OracleConnection(strConn);
                    return true;
                }
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }

        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            sql = "((" + sql + "))";
            OracleDataAdapter DataAdapter = new OracleDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp OracleCommand
            DataAdapter.SelectCommand = new OracleCommand();

            DataAdapter.SelectCommand.Connection = DBUtils.Con; //Kết nối cơ sở dữ liệu
            DataAdapter.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            DataAdapter.Fill(table);
            return table;
        }

        public static bool CheckValue(string sql)
        {
            sql = "((" + sql + "))";
            OracleDataAdapter dap = new OracleDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static bool RunSQL(string sql)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Con;
            cmd.CommandText = sql;
            int kq = 0;
            try
            {
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
            if (kq > 0)
                return true;
            return false;
        }

        public static void RunSqlDel(string sql)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBUtils.Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
