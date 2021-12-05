using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    public class Firm
    {
        List<Administrator> administrators;
        List<Worker> workers;

        public Firm()
        {
            administrators = new List<Administrator>();
            workers = new List<Worker>();
        }

        public Firm(List<Administrator> administrator_List, List<Worker> workers_List)
        {
            administrators = administrator_List;
            workers = workers_List;
        }

        public Firm(List<Administrator> administrator_List)
        {
            administrators = administrator_List;
        }

        public Firm(List<Worker> workers_List)
        {
            workers = workers_List;
        }

        public List<Administrator> Administrators
        {
            get { return administrators; }
            set { administrators = value; }
        }

        public List<Worker> Workers
        {
            get { return workers; }
            set { workers = value; }
        }
    }
}
