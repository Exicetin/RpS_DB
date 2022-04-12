using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            
            //Валидация широты
            //string pattern = "[0-9]{2}.[0-9]{5}";
            //string str = Latitude.Text;
            //string strRepl = @"\d{3}.\d{3}";

            //Regex regex = new Regex(pattern);

            //if (regex.IsMatch(str)) {
            //    string str1 = Regex.Replace(str,pattern,strRepl);
            //    Latitude.Text = str1;   
            //}

            //string pattern = "[0-9]{2}.[0-9]{5}";
            //string str = Latitude.Text;
            //string strRepl = @"\d{3}.\d{3}";
            //Regex regex = new Regex(pattern);

            //bool sravn = regex.IsMatch(str);

            //if (sravn == true)
            //{
            //    return;
            //}
            //else if (sravn == false)
            //{
            //    string str1 = Regex.Replace(str, pattern, strRepl);
            //}
        }



        public void All_Reports(object sender, RoutedEventArgs e)
        {
            All_Report allReport = new All_Report();
            allReport.Show();
            this.Close();        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

        }
    }
}

