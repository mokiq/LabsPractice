using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    public abstract class Transport
    {
        private string year;
        private string number;
        private string mark;

        public Transport()
        {
            year = "2020";
            number = "5PPP064";
            mark = "Dodge";
        }

        public Transport(string set_Year, string set_Number, string set_Mark)
        {
            year = set_Year;
            number = set_Number;
            mark = set_Mark;
        }

        #region // get values

        public string get_Year()
        {
            return year;
        }

        public string get_Number()
        {
            return number;
        }

        public string get_Mark()
        {
            return mark;
        }
        #endregion
    }

    public class Auto : Transport
    {
        private int max_Speed;

        public Auto() : base()
        {
            max_Speed = 280;
        }

        public Auto(int set_MaxSpeed, string set_Year, string set_Number, string set_Mark) : base(set_Year:set_Year, set_Number:set_Number, set_Mark:set_Mark)
        {
            max_Speed = set_MaxSpeed;
        }

        public int get_MaxSpeed()
        {
            return max_Speed;
        }
    }

    public class Bus : Transport
    {
        private int seats;

        public Bus(): base()
        {
            seats = 31;
        }

        public Bus(int set_Seats, string set_Year, string set_Number, string set_Mark) : base(set_Year: set_Year, set_Number: set_Number, set_Mark: set_Mark)
        {
            seats = set_Seats;
        }

        public int get_Seats()
        {
            return seats;
        }
    }
}
