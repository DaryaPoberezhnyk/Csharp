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
using System.Xml.Linq;

namespace wpfexam.Views.admin
{
    /// <summary>
    /// Interaction logic for ManageStudents_CRUD_.xaml
    /// </summary>
    public class Student
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string HomeAddress { get; set; }
        public string School { get; set; }
        // інші властивості студента
    }

    public partial class ManageStudents_CRUD_ : Window
    {
       
        public ManageStudents_CRUD_()
        {
            InitializeComponent();
           

        }
        private List<Student> students = new List<Student>();

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Отримання даних з полів введення
            string name = NameTextBox.Text;
            string surname = SurnameBox.Text;
            string fatherName = fatherTextBox.Text;
            string phoneNumber = numberTextBox.Text;
            string email = tmailTextBox.Text;
            string birthday = birthdayTextBox.Text;
            string homeAddress = homeTextBox.Text;
            string school = schoolTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(fatherName) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(birthday) || string.IsNullOrWhiteSpace(homeAddress) || string.IsNullOrWhiteSpace(school))
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
           

            // Створення об'єкта студента
            Student newStudent = new Student
            {
                Name = name,
                Surname = surname,
                FatherName = fatherName,
                PhoneNumber = phoneNumber,
                Email = email,
                Birthday = birthday,
                HomeAddress = homeAddress,
                School = school
            };

            // Додавання студента до колекції
            students.Add(newStudent);

            // Оновлення інформації про нового студента на інтерфейсі
            studentInfoTextBlock.Text = $"4. {newStudent.Surname} {newStudent.Name}\n {newStudent.FatherName}";

        }

        private void ClearInputFields()
        {
            // Очищення всіх полів введення
            NameTextBox.Clear();
            SurnameBox.Clear();
            fatherTextBox.Clear();
            numberTextBox.Clear();
            tmailTextBox.Clear();
            birthdayTextBox.Clear();
            homeTextBox.Clear();
            schoolTextBox.Clear();
        }
    }
}
