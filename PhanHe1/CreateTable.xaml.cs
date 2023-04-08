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

namespace PhanHe1
{
    /// <summary>
    /// Interaction logic for CreateTable.xaml
    /// </summary>
    public partial class CreateTable : Window
    {
        public CreateTable()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void change(object sender, TextChangedEventArgs e)
        {

        }

        private void dgvTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void change2(object sender, DataGridRowEditEndingEventArgs e)
        {

        }
        private void change4(object sender, EventArgs e)
        {
            
        }
        private void change(object sender, RoutedEventArgs e)
        {

            
        }
        public class Table
        {
            public bool PrimaryKey { get; set; }
            public string ColumnName { get; set; }
            public string Type { get; set; }
            public bool NotNULL { get; set; }
            public string Default { get; set; }
        }
    }
}
