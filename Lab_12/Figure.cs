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
    class Shape
    {
        private Color color;
        private float thickness;

        public virtual void Perimeter() { }
        public virtual void Area() { }

        public Shape()
        {
            color = Color.FromRgb(255, 255, 255);
            thickness = 5;
        }

        public Shape(Color setColor, float setThickness)
        {
            color = setColor;
            thickness = setThickness;
        }
        #region // get values
        public Color get_Color()
        {
            return color;
        }

        public float get_Thickness()
        {
            return thickness;
        }

        public void set_Color(Color setColor)
        {
            color = setColor;
        }

        public void set_Thickness(float setThickness)
        {
            thickness = setThickness;
        }
        #endregion
    }

    class Square : Shape
    {
        private float width;
        private float height;

        private float perimetr;
        private float area;

        public Square() : base()
        {
            perimetr = 0;
            area = 0;
        }

        public Square(float setWidth, float setHeight, Color setColor, float setThickness) : base(setColor: setColor, setThickness: setThickness)
        {
            width = setWidth;
            height = setHeight;

            perimetr = 2 * (setWidth + setHeight);
            area = setWidth * setWidth;
        }

        public override void Perimeter()
        {
            perimetr = 2 * (width + height);
        }

        public override void Area()
        {
            area = get_Width() * get_Width();
        }

        public float get_Width()
        {
            return width;
        }

        public float get_Height()
        {
            return height;
        }

        public void set_Width(float set_Width)
        {
            width = set_Width;
        }

        public void set_Height(float set_Height)
        {
            height = set_Height;
        }

        public float get_Perimetr()
        {
            return perimetr;
        }

        public float get_Area()
        {
            return area;
        }
    }

    class Rectangle : Square
    {
        private float perimetr;
        private float area;

        public Rectangle() : base()
        {
            perimetr = 0;
            area = 0;
        }
        public Rectangle(float setWidth, float setHeight, Color setColor, float setThickness) : base(setWidth: setWidth, setHeight: setHeight, setColor: setColor, setThickness: setThickness)
        {
            perimetr = 4 * setWidth;
            area = setWidth * setHeight;
        }

        public override void Perimeter()
        {
            perimetr = 4 * base.get_Width();
        }

        public override void Area()
        {
            area = base.get_Width() * base.get_Height();
        }

        public float get_Perimetr()
        {
            return perimetr;
        }

        public float get_Area()
        {
            return area;
        }
    }
}
