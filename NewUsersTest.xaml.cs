using System.Windows;

namespace RpS2._0
{
    public partial class NewUsersTest : Window
    {
        public User User { get; private set; }

        public NewUsersTest(User p)
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            User = p;
            this.DataContext = User;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void All_Reports(object sender, RoutedEventArgs e)
        {
            All_Report allReport = new All_Report();
            allReport.Show();
            this.Close();

        }
    }
}
