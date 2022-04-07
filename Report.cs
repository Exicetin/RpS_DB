using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RpS2._0
{
    public class Report : INotifyPropertyChanged
    {

        private string dateRep;
        private string title;
        private string description;
        private string routeDescription;
        private string latitude;
        private string longitude;
        private string north;
        private string east;
        private string target;
        private string compound;
        private string result;
        private string developer;
        private string faculty;
        private string groupDev;

        [Key]
        public int IdReport { get; set; }

        public string DateRep
        {
            get { return dateRep; }
            set
            {
                dateRep = value;
                OnPropertyChanged("Date");
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }


        public string RouteDescription
        {
            get { return routeDescription; }
            set
            {
                routeDescription = value;
                OnPropertyChanged("RouteDescription");
            }
        }
        public string Latitude
        {
            get { return latitude; }
            set
            {
                latitude = value;
                OnPropertyChanged("Latitude");
            }
        }
        public string North
        {
            get { return north; }
            set
            {
                north = value;
                OnPropertyChanged("North");
            }
        }

        public string Longitude
        {
            get { return longitude; }
            set
            {
                longitude = value;
                OnPropertyChanged("Longitude");
            }
        }


        public string East
        {
            get { return east; }
            set
            {
                east = value;
                OnPropertyChanged("East");
            }
        }
        public string Target
        {
            get { return target; }
            set
            {
                target = value;
                OnPropertyChanged("Target");
            }
        }
        public string Compound
        {
            get { return compound; }
            set
            {
                compound = value;
                OnPropertyChanged("Compound");
            }
        }
        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }
        public string Developer
        {
            get { return developer; }
            set
            {
                developer = value;
                OnPropertyChanged("Developer");
            }
        }
        public string Faculty
        {
            get { return faculty; }
            set
            {
                faculty = value;
                OnPropertyChanged("Faculty");
            }
        }

        public string GroupDev
        {
            get { return groupDev; }
            set
            {
                groupDev = value;
                OnPropertyChanged("Group");
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
