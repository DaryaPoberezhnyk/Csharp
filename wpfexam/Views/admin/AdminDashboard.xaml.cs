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

namespace wpfexam.Views.admin
{
    /// <summary>
    /// Interaction logic for AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : Window
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            // Відкриття нового вікна StudentsInfo
            ManageStudents_CRUD_ manageStudents = new ManageStudents_CRUD_();
            manageStudents.Show();

            // Закриття поточного вікна
            this.Close();

        }
        private void Image1_3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            // Відкриття нового вікна StudentsInfo.xaml
            ManageTeachers_CRUD_ manageTeachers_CRUD = new ManageTeachers_CRUD_();
            manageTeachers_CRUD.Show();
            // Закриття поточного вікна
            this.Close();

        }
    }
}