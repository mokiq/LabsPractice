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
    /// Логика взаимодействия для TransportWindow.xaml
    /// </summary>
    public partial class TransportWindow : Window
    {
        private string number;
        private string year;
        private string mark;

        private int max_Speed;
        private int seats;

        public TransportWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch((sender as Button).Tag.ToString())
            {
                case "ClearAll":
                    ClearValues();
                    break;
                case "CreateAuto":
                    ClearAuto();

                    number = number_TextBox.Text;
                    year = year_TextBox.Text;
                    mark = mark_TextBox.Text;

                    max_Speed = int.Parse(maxSpeed_TextBox.Text);
                    Auto auto = new Auto(set_Mark:mark, set_MaxSpeed:max_Speed, set_Number:number, set_Year:year);

                    autoNumber_TextBox.Text += auto.get_Number();
                    autoYear_TextBox.Text += auto.get_Year();
                    autoMark_TextBox.Text += auto.get_Mark();
                    autoMaxSpeed_TextBox.Text += auto.get_MaxSpeed().ToString();
                    break;
                case "CreateBus":
                    ClearBus();

                    number = number_TextBox.Text;
                    year = year_TextBox.Text;
                    mark = mark_TextBox.Text;

                    seats = int.Parse(seats_TextBox.Text);

                    Bus bus = new Bus(set_Mark: mark, set_Seats: seats, set_Number: number, set_Year: year);

                    busNumber_TextBox.Text += bus.get_Number();
                    busYear_TextBox.Text += bus.get_Year();
                    busMark_TextBox.Text += bus.get_Mark();
                    busSeats_TextBox.Text += bus.get_Seats().ToString();

                    ClearValues();
                    break;
                case "ClearBus":
                    ClearBus();
                    break;
                case "ClearAuto":
                    ClearAuto();
                    break;

            }
        }

        private void ClearValues()
        {
            number_TextBox.Text = null;
            year_TextBox.Text = null;
            maxSpeed_TextBox.Text = null;
            seats_TextBox.Text = null;
            mark_TextBox.Text = null;
        }

        private void ClearAuto()
        {
            autoNumber_TextBox.Text = "Number: ";
            autoYear_TextBox.Text = "Year: ";
            autoMark_TextBox.Text = "Mark: ";
            autoMaxSpeed_TextBox.Text = "Max speed: ";
        }

        private void ClearBus()
        {
            busNumber_TextBox.Text = "Number: ";
            busYear_TextBox.Text = "Year: ";
            busMark_TextBox.Text = "Mark: ";
            busSeats_TextBox.Text = "Seats: ";
        }
    }
}
