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
    /// Interaction logic for StudentsProfile.xaml
    /// </summary>
    public partial class StudentsProfile : Window
    {
        public StudentsProfile()
        {
            InitializeComponent();
        }
        private void Image6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            // Відкриття нового вікна StudentsInfo.xaml
            StudentsInfo studentsInfo = new StudentsInfo();
            studentsInfo.Show();
            // Закриття поточного вікна
            this.Close();

        }

        private void Image5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            // Відкриття нового вікна StudentsHome.xaml
            StudentsHome studentsHome = new StudentsHome();
            studentsHome.Show();
            // Закриття поточного вікна
            this.Close();

        }
    }
}
