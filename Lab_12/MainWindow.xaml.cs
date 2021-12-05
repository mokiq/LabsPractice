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

namespace Lab_12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Windows.FigureWindow figureWindow;
        Windows.StudentWindow studentWindow;
        Windows.TransportWindow transportWindow;

        public MainWindow()
        {
            InitializeComponent();

            Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (figureWindow != null)
            {
                figureWindow.Close();
            }

            if (studentWindow != null)
            {
                studentWindow.Close();
            }

            if (transportWindow != null)
            {
                transportWindow.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch((sender as Button).Tag.ToString())
            {
                case "Figures":
                    figureWindow = new Windows.FigureWindow();
                    figureWindow.ShowDialog();
                    break;
                case "Student":
                    studentWindow = new Windows.StudentWindow();
                    studentWindow.ShowDialog();
                    break;
                case "Transport":
                    transportWindow = new Windows.TransportWindow();
                    transportWindow.ShowDialog();
                    break;
            }
        }
    }
}
