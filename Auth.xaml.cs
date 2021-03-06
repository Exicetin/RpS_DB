using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace RpS2._0
{
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }
        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text.Trim(); /*Получаем знаечние поля Login, удаляем лишние пробелы до и после и приводим к нижнему регистру*/
            string password = Password.Password.Trim(); /*Получаем значение поля PassBox и удаляем лишние пробелы в начале и конце строки*/

            if (password != "Admin" || password.Length < 5)
            {
                Mess.Text = "Проверьте правильность введенных данных";
                Password.BorderBrush = Brushes.DarkRed;
            }
            else
            {
                Password.ToolTip = "";
                Password.BorderBrush = Brushes.LightGray;
                Login.ToolTip = "";
                Login.BorderBrush = Brushes.LightGray;
                User authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.UserPassword == password && b.Login ==
                       login).FirstOrDefault();
                }
                if (authUser == null)
                {
                    Login.BorderBrush = Brushes.DarkRed;
                    Password.BorderBrush = Brushes.DarkRed;
                    Mess.Text = "Необходимо заполнить все поля";
                    //MessageBox.Show("Необходимо заполнить поля!");
                }
                if (authUser != null)
                {
                    if (password == "Admin")
                    {
                        All_Report allReport = new All_Report();
                        allReport.Show();
                        this.Close();
                    }
                    else
                    {
                        All_Report allReport = new All_Report();
                        allReport.Show();
                        this.Close();
                    }
                }
                else
                {
                    Mess.Text = "Неверно указаны данные!";
                }
            }
        }
        private void Recovery_Button(object sender, RoutedEventArgs e)
        {
            AuthRecovery authRecovery = new AuthRecovery();
            authRecovery.Show();
            this.Close();
        }

    }
}
