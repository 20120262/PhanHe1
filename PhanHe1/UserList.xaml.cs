using System;
using System.Collections.Generic;
using System.Data;
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

namespace PhanHe1
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : Window
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void dgvUser_RowContentClick(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGrant_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbChange(object sender, RoutedEventArgs e)
        {

        }
        private void dgvRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (dgvRole.SelectedIndex < 0)
            //    return;
            //btnDeleteUser.IsEnabled = true;
            //btnGrant.IsEnabled = true;
            //btnChangePass.IsEnabled = false;
            //btnUnlock.IsEnabled = false;
            //btnLock.IsEnabled = false;
            //dgvUser.SelectedIndex = -1;

            //DataRowView curRow = dgvRole.SelectedItem as DataRowView;
            //string Role = curRow.Row.ItemArray[0].ToString();
        }
    }
}
