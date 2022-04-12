using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для AllUsersTest.xaml
    /// </summary>
    public partial class AllUsersTest : Window
    {
        ApplicationContext db;
        public AllUsersTest()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            db = new ApplicationContext();
            db.Users.Load();
            this.DataContext = db.Users.Local.ToBindingList();
        }
        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NewUsersTest phoneWindow = new NewUsersTest(new User());
            if (phoneWindow.ShowDialog() == true)
            {
                User user = phoneWindow.User;
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (userList.SelectedItem == null) return;
            // получаем выделенный объект
            User user = userList.SelectedItem as User;

            NewUsersTest newUsersTest = new NewUsersTest(new User
            {
                IdUser = user.IdUser,
                Surname = user.Surname,
                Name = user.Name,
                MidleName = user.MidleName,
                Login = user.Login,
                UserPassword = user.UserPassword,
                RecoveryCode = user.RecoveryCode

    });

            if (newUsersTest.ShowDialog() == true)
            {
                // получаем измененный объект
                user = db.Users.Find(newUsersTest.User.IdUser);
                if (user != null)
                {
                    user.Surname = newUsersTest.User.Surname;
                    user.Name = newUsersTest.User.Name;
                    user.MidleName = newUsersTest.User.MidleName;
                    user.Login = newUsersTest.User.Login;
                    user.UserPassword = newUsersTest.User.UserPassword;
                    user.RecoveryCode = newUsersTest.User.RecoveryCode;
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (userList.SelectedItem == null) return;
            // получаем выделенный объект
            User user = userList.SelectedItem as User;
            db.Users.Remove(user);
            db.SaveChanges();
        }
        private void All_Report(object sender, RoutedEventArgs e)
        {
            All_Report all_Report = new All_Report();
            all_Report.Show();
            this.Close();
        }
    }
}