using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    public class Worker : Human
    {
        private string place_of_work;
        private int work_experience;

        public Worker() : base()
        {
            place_of_work = string.Empty;
            work_experience = 0;
        }

        public Worker(string First_Name, string Last_Name, int Age, string Place_Of_Work, int Work_Experience) : base(First_Name:First_Name, Last_Name:Last_Name, Age:Age)
        {
            this.place_of_work = Place_Of_Work;
            this.work_experience = Work_Experience;
        }

        public string Place_Of_Work
        {
            get {  return place_of_work;}
            set {  place_of_work = value; }
        }

        public int Work_Experience
        {
            get {  return work_experience;}
            set {  work_experience = value; }
        }

    }
}
 