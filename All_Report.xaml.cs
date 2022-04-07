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
    public partial class All_Report : Window
    {
        ApplicationContext db;
        public All_Report()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Reports.Load();
            this.DataContext = db.Reports.Local.ToBindingList();
        }
        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NewReport newReport = new NewReport(new Report());
            if (newReport.ShowDialog() == true)
            {
                Report report = newReport.Report;
                db.Reports.Add(report);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (reportList.SelectedItem == null) return;
            // получаем выделенный объект
            Report report = reportList.SelectedItem as Report;

            NewReport newReport = new NewReport(new Report
            {
                IdReport = report.IdReport,
                Title = report.Title,
                Date = report.Date,
                Description = report.Description,
                RouteDescription = report.RouteDescription,
                Latitude = report.Latitude,
                North = report.North,
                Longitude = report.Longitude,
                East = report.East,
                Target = report.Target,
                Compound = report.Compound,
                Result = report.Result,
                Developer = report.Developer,
                Faculty = report.Faculty,
                Group = report.Group
            });

            if (newReport.ShowDialog() == true)
            {
                // получаем измененный объект
                report = db.Reports.Find(newReport.Report.IdReport);
                if (report != null)
                {
                    report.Date = newReport.Report.Date;
                    report.Title = newReport.Report.Title;
                    report.Description = newReport.Report.Description;
                    report.RouteDescription = newReport.Report.RouteDescription;
                    report.Latitude = newReport.Report.Latitude;
                    report.North = newReport.Report.North;
                    report.Longitude = newReport.Report.Longitude;
                    report.East = newReport.Report.East;
                    report.Target = newReport.Report.Target;
                    report.Compound = newReport.Report.Compound;
                    report.Result = newReport.Report.Result;
                    report.Developer = newReport.Report.Developer;
                    report.Faculty = newReport.Report.Faculty;
                    report.Group = newReport.Report.Group;

                    db.Entry(report).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (reportList.SelectedItem == null) return;
            // получаем выделенный объект
            User user = reportList.SelectedItem as User;
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}
