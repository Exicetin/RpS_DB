using System.Linq;
using System.Windows;

namespace RpS2._0
{
    public partial class AuthRecovery : Window
    {


        public AuthRecovery()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        private void Return_Button(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }

        private void Recovery_Button(object sender, RoutedEventArgs e)
        {
            int recoveryCode = int.Parse(RecCode.Text);
            User recovery = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                recovery = db.Users.Where(b => b.RecoveryCode == recoveryCode).FirstOrDefault();
            }
            if (recovery != null)
            {
                Recover.Text = "Востановление прошло успешно";
                //Добавить скрытую кнопку продолжения - ввод новых данных и апдейт базы
                Auth auth = new Auth();
                auth.Show();
                this.Close();
            }
            else
            {
                Recover.Text = "В востановлении доступа отказано!";

                Auth auth = new Auth();
                auth.Show();
                this.Close();
            }

        }
    }
}
