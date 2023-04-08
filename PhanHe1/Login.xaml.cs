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
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Security.Claims;




namespace PhanHe1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Password.ToString();

            if (string.IsNullOrEmpty(username))
            {
                txtWarning.Text = "Bạn chưa nhập tên đăng nhập";
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                txtWarning.Text = "Bạn chưa nhập mật khẩu";
                return;
            }

            //Dùng để đăng nhập nhanh (chỉ dùng khi test)
            if (username == "1")
            {   // admin
                username = "QLTT";
                password = "admin123";
            }

            else if (username == "cs")
            {   // QL_CSYT
                username = "U231353133";
                password = "01042001";
            }

            else if (username == "bn")
            {   // Bệnh nhân
                username = "U946301145";
                password = "13031953";
            }

            else if (username == "tt")
            {   // Thanh tra
                username = "U232630930";
                password = "15111952";
            }

            else if (username == "nc")
            {   // Nghiên cứu
                username = "U757592857";
                password = "08071994";
            }

            else if (username == "bs")
            {   // Bác sĩ
                username = "U868387298";
                password = "05101980";
            }

            else if (username == "gds")
            {   // Giám đốc sở y tế
                username = "U234567890";
                password = "24031990";
            }

            bool isConnect = Class.DBUtils.Connect(username, password);
            if (isConnect)  // Kết nối thành công
            {
                try
                {
                    
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                txtUsername.Text = "";
                txtPassword.Password = "";
                
            }


        }
        
        //private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông báo", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
        //    {
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        Environment.Exit(0);
        //    }

        //}

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
