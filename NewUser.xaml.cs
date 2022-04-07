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

namespace RpS2._0
{

    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        private void New_Report_Click(object sender, RoutedEventArgs e)
        {
            NewReport taskWindow = new NewReport();
            taskWindow.Show();
            this.Close();
        }
    }
}
