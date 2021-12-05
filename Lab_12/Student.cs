using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    /*
     * Напишите объявления для следующих диаграмм классов, включив в него члены-данные, конструкторы по умолчанию и с параметрами,
     * методы доступа, методы ввода-вывода для клавиатуры и экрана и т.д. : 
     */
    public abstract class Student
    {
        private int number;
        private string name;

        public enum gender_Option
        {
            Male,
            Female
        }
        private gender_Option gender;

        public Student()
        {
            number = 0;
            gender = gender_Option.Female;
            name = "Name";
        }

        public Student(int set_Num, string set_Name, gender_Option gender_Op)
        {
            number = set_Num;
            gender = gender_Op;
            name = set_Name;
        }

        #region // get values
        public int get_Num()
        {
            return number;
        }

        public string get_Name()
        {
            return name;
        }

        public gender_Option get_Gender()
        {
            return gender;
        }
        #endregion
    }

    public class Ext_Student: Student
    {
        private string post;
        private string work_Place;

        public Ext_Student(string set_Post, string set_WorkPlace) : base()
        {
            post = set_Post;
            work_Place = set_WorkPlace;
        }

        public Ext_Student(string set_Post, string set_WorkPlace, int set_Num, string set_Name, gender_Option gender_Op) : base(set_Name: set_Name, set_Num: set_Num, gender_Op:gender_Op)
        {
            post = set_Post;
            work_Place = set_WorkPlace;
        }

        #region // get values
        public string get_Post()
        {
            return post;
        }

        public string get_WorkPlace()
        {
            return work_Place;
        }
        #endregion
    }
}
