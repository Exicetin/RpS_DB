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
    /// <summary>
    /// Логика взаимодействия для NewReport.xaml
    /// </summary>
    public partial class NewReport : Window
    {
        public Report Report { get; private set; }

        public NewReport(Report r)
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            Report = r;
            this.DataContext = Report;
        }

        public NewReport()
        {
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

        }
    }
}

