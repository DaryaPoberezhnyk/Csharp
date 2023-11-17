using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
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
    /// Interaction logic for ManageTeachers_CRUD_.xaml
    /// </summary>

    public class Teacher
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Spetsiality { get; set; }
    }

    
   

    public partial class ManageTeachers_CRUD_ : Window
    {
        public ManageTeachers_CRUD_()
        {
            InitializeComponent();
        }

        private List<Teacher> teachers = new List<Teacher>();

        private void LoginButton1_Click(object sender, RoutedEventArgs e)
        {
            // Отримання даних з полів введення
            string name = NameTextBox.Text;
            string surname = SurnameBox.Text;
            string fatherName = fatherTextBox.Text;
            string phoneNumber = numberTextBox.Text;
            string spetsiality = spetsialityTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(fatherName) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(spetsiality))
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            // Створення об'єкта студента
            Teacher newTeacher = new Teacher
            {
                Name = name,
                Surname = surname,
                FatherName = fatherName,
                PhoneNumber = phoneNumber,
                Spetsiality = spetsiality
            };

            // Додавання студента до колекції
            teachers.Add(newTeacher);


            bool isSpecialTeacher = newTeacher.Spetsiality.Contains("особливий", StringComparison.OrdinalIgnoreCase);


            // Оновлення інформації про нового студента на інтерфейсі
            if (isSpecialTeacher)
            {
                teacherInfoTextBlock.Text = $"{newTeacher.Surname} {newTeacher.Name} {newTeacher.FatherName}\n\n       {newTeacher.Spetsiality} ";
                InfoGrid1.Visibility = Visibility.Visible;
                InfoGrid2.Visibility = Visibility.Collapsed;
            }
            else
            {
                teacherInfoTextBlock1.Text = $"{newTeacher.Surname} {newTeacher.Name} {newTeacher.FatherName}\n\n       {newTeacher.Spetsiality} ";
                InfoGrid2.Visibility = Visibility.Visible;
                InfoGrid1.Visibility = Visibility.Collapsed;

            }
            ClearInputFields();


        }


        private void Image1_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            // Відкриття нового вікна StudentsInfo.xaml
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            // Закриття поточного вікна
            this.Close();

        }
        private void Image1_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            // Ваш код для видалення елементів, наприклад:
            InfoBorder.Visibility = Visibility.Collapsed;
            InfoTextBlock.Visibility = Visibility.Collapsed;
            InfoLine.Visibility = Visibility.Collapsed;
            InfoImage.Visibility = Visibility.Collapsed;
            InfoTextBlock1.Visibility = Visibility.Collapsed;
            InfoTextBlock2.Visibility = Visibility.Collapsed;
            InfoImage1.Visibility = Visibility.Collapsed;
            NewImage1.Visibility = Visibility.Visible;

        }

        private void Image2_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            // Ваш код для видалення елементів, наприклад:
            InfoBorder1.Visibility = Visibility.Collapsed;
            InfoTextBlock3.Visibility = Visibility.Collapsed;
            InfoLine1.Visibility = Visibility.Collapsed;
            InfoImage2.Visibility = Visibility.Collapsed;
            InfoTextBlock4.Visibility = Visibility.Collapsed;
            InfoTextBlock5.Visibility = Visibility.Collapsed;
            InfoImage3.Visibility = Visibility.Collapsed;

            NewImage.Visibility = Visibility.Visible;

        }
       
        
        private void Image3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            InfoGrid.Visibility = Visibility.Visible;
        }

        private void Image4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            InfoGrid.Visibility = Visibility.Visible;
        }

        private void ClearInputFields()
        {
            // Очищення всіх полів введення
            NameTextBox.Clear();
            SurnameBox.Clear();
            fatherTextBox.Clear();
            numberTextBox.Clear();
            spetsialityTextBox.Clear();

        }
    }
}
