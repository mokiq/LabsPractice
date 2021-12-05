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
    /// Логика взаимодействия для FigureWindow.xaml
    /// </summary>
    public partial class FigureWindow : Window
    {
        Square square;
        Rectangle rectangle;

        private float width;
        private float height;
        private float thickness;
        private Color color;

        public FigureWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Tag.ToString())
            {
                case "ClearAll":
                    width_TextBox.Text = null;
                    height_TextBox.Text = null;
                    thickness_TextBox.Text = null;
                    break;
                case "CreateSquare":
                    width = float.Parse(width_TextBox.Text);
                    height = float.Parse(height_TextBox.Text);

                    thickness = float.Parse(thickness_TextBox.Text);

                    color = colorPicker.SelectedColor;

                    square = new Square(setWidth: width, setHeight: height, setThickness: thickness, setColor: color);

                    f_Square.Stroke = new SolidColorBrush(square.get_Color());
                    f_Square.Width = square.get_Width();
                    f_Square.Height = square.get_Height();
                    f_Square.StrokeThickness = square.get_Thickness();
                    break;
                case "CreateRectangle":
                    width = float.Parse(width_TextBox.Text);
                    height = float.Parse(height_TextBox.Text);

                    thickness = float.Parse(thickness_TextBox.Text);

                    color = colorPicker.SelectedColor;

                    rectangle = new Rectangle(setWidth: width, setHeight: height, setThickness: thickness, setColor: color);

                    f_Rectangle.Stroke = new SolidColorBrush(rectangle.get_Color());
                    f_Rectangle.Width = rectangle.get_Width();
                    f_Rectangle.Height = rectangle.get_Height();
                    f_Rectangle.StrokeThickness = rectangle.get_Thickness();
                    break;
                case "ClearSquare":
                    f_Square.Width = 0;
                    f_Square.Height = 0;

                    f_Square.Stroke = null;
                    f_Square.StrokeThickness = 0;
                    break;
                case "ClearRectangle":
                    f_Rectangle.Width = 0;
                    f_Rectangle.Height = 0;

                    f_Rectangle.Stroke = null;
                    f_Rectangle.StrokeThickness = 0;
                    break;
                case "AreaSquare":
                    MessageBox.Show(square.get_Area().ToString(), "Result!");
                    break;
                case "AreaRectangle":
                    MessageBox.Show(rectangle.get_Area().ToString(), "Result!");
                    break;
                case "PerimetrSquare":
                    MessageBox.Show(square.get_Perimetr().ToString(), "Result!");
                    break;
                case "PerimetrRectangle":
                    MessageBox.Show(rectangle.get_Perimetr().ToString(), "Result!");
                    break;
            }
        }
    }
}
