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
using System.Windows.Shapes;

namespace Lab_12.Windows
{
    /// <summary>
    /// Логика взаимодействия для StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        Ext_Student ext_Student;

        private int number;
        private string name;
        private Student.gender_Option gender;
        private string work_Place;
        private string post;

        public StudentWindow()
        {
            InitializeComponent();
            gender_comboBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch((sender as Button).Tag.ToString())
            {
                case "ClearAll":
                    ClearValues();
                    break;
                case "Create":
                    ClearStudent();
                    number = int.Parse(number_TextBox.Text);
                    name = name_TextBox.Text;
                    work_Place = workPlace_TextBox.Text;
                    post = post_TextBox.Text;

                    switch(gender_comboBox.SelectedItem as string)
                    {
                        case "Male":
                            gender = Student.gender_Option.Male;
                            break;
                        case "Female":
                            gender = Student.gender_Option.Female;
                            break;
                    }

                    ext_Student = new Ext_Student(set_Name:name, set_Num:number, set_Post:post, set_WorkPlace:work_Place, gender_Op:gender);

                    studentName_TextBox.Text += ext_Student.get_Name();
                    studentNumber_TextBox.Text += ext_Student.get_Num().ToString();
                    studentPost_TextBox.Text += ext_Student.get_Post();
                    studentWorkPlace_TextBox.Text += ext_Student.get_WorkPlace();
                    
                    studentGender_TextBox.Text += ext_Student.get_Gender().ToString();

                    ClearValues();
                    break;
                case "Clear":
                    ClearStudent();
                    break;
            }
        }

        private void ClearValues()
        {
            number_TextBox.Text = null;
            name_TextBox.Text = null;
            workPlace_TextBox.Text = null;
            post_TextBox.Text = null;
        }

        private void ClearStudent()
        {
            studentName_TextBox.Text = "Name: ";
            studentNumber_TextBox.Text = "Number: ";
            studentPost_TextBox.Text = "Post: ";
            studentWorkPlace_TextBox.Text = "Work place: ";
            studentGender_TextBox.Text = "Gender: ";
        }
    }
}
