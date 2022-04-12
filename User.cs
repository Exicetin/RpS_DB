using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
namespace RpS2._0
{

    public class User : INotifyPropertyChanged
    {

        private string surname;
        private string name;
        private string midle_name;
        private string login;
        private string userPassword;
        private int recoveryCode;

        [Key]
        public int IdUser { get; set; }

        public string Surname 
        { 
            get { return surname; }
            set 
            {
                surname = value;
                OnPropertyChanged("Title");
            }
        }
       
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string MidleName
        {
            get { return midle_name; }
            set
            {
                midle_name = value;
                OnPropertyChanged("MidleName");
            }
        }

        public string Login
        {
            get { return login; }
            set 
            { 
                login = value; 
                OnPropertyChanged("Login");
            }
        }
        public string UserPassword
        {
            get { return userPassword; }
            set
            {
                userPassword = value; 
                OnPropertyChanged("Password");
            }
        }
        public int RecoveryCode
        {
            get { return recoveryCode; }
            set
            {
                recoveryCode = value; 
                OnPropertyChanged("RecoveryCode");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
