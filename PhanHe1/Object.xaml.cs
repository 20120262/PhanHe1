using Oracle.ManagedDataAccess.Client;
using PhanHe1.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhanHe1
{
    /// <summary>
    /// Interaction logic for Object.xaml
    /// </summary>
    public partial class Object : Window
    {
        public Object()
        {
            InitializeComponent();
            HienThi("Tất cả");
        }
        private void HienThi(string ob)
        {
            OracleCommand command = Class.DBUtils.Con.CreateCommand();
            string sql = "SELECT OBJECT_NAME, OBJECT_TYPE, CREATED, STATUS" +
                " FROM USER_OBJECTS WHERE OBJECT_TYPE != 'SEQUENCE'";
            if (ob != "Tất cả")
            {
                sql = sql + " AND OBJECT_TYPE = '" + ob.ToUpper() + "'";
            }
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            OracleDataReader dr = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dr);

            dgvObject.ItemsSource = null;
            dgvObject.ItemsSource = dataTable.DefaultView;
        }

        private void Object_Checked(object sender, RoutedEventArgs e)
        {
            var button = sender as RadioButton;
            HienThi(button.Content.ToString());
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateTable admin_CreateTable = new CreateTable();
            admin_CreateTable.ShowDialog();
            HienThi("Tất cả");
        }
        private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Show();

        }
    }
}
