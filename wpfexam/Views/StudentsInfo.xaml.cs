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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfexam.Views
{
    /// <summary>
    /// Interaction logic for StudentsInfo.xaml
    /// </summary>
    public partial class StudentsInfo : Window
    {
        public StudentsInfo()
        {
            InitializeComponent();

        }
        private void Image5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            // Відкриття нового вікна StudentsInfo.xaml
            StudentsHome studentsHome = new StudentsHome();
            studentsHome.Show();

            // Закриття поточного вікна
            this.Close();
        }
        private void Image12_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            // Створення і відкриття нового вікна StudentsInfo.xaml
            StudentsProfile studentsProfile = new StudentsProfile();
            studentsProfile.Show();

            // Закриття поточного вікна
            this.Close();
        }
    }
}
