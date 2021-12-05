using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    public abstract class Human
    {
        private string first_Name;
        private string last_Name;
        private int Age;

        public Human()
        {
            first_Name = string.Empty;
            last_Name = string.Empty;
            Age = 0;
        }

        public Human(string First_Name, string Last_Name,int Age)
        {
            this.first_Name = First_Name;
            this.last_Name = Last_Name;
            this.Age = Age;
        }

        public string FirstName
        {
            get {  return first_Name;}
            set {  first_Name = value; }
        }

        public string LastName
        {
            get {  return last_Name;}
            set {  last_Name = value; }
        }

        public int HumanAge
        {
            get {  return Age;}
            set {  Age = value; }
        }
    }
}
