using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Oracle.ManagedDataAccess.Client;

namespace PhanHe1
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
     

        private void btnAllUser_Click(object sender, RoutedEventArgs e)
        {
           // this.Close();
            UserList userlist = new UserList();
            this.Hide();
            userlist.ShowDialog();
            this.Show();
        }

        private void btnPriv_Click(object sender, RoutedEventArgs e)
        {
            UserPrivs uprivs = new UserPrivs();
            this.Hide();
            uprivs.ShowDialog();
            this.Show();
        }

        private void btnObject_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            Object obj = new Object();
            obj.Show();
            this.Close();
        }
        private void btn_DangXuat_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
        private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           this.Close();
            Login login = new Login();
            login.txtPassword.Password = " ";
            login.txtUsername.Text = " ";
            this.Hide();
            login.ShowDialog();
            this.Show();

        }
    }
}
