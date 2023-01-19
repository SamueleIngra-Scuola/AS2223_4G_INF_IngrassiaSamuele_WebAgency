using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Employee
    {
        protected string name;
        protected string lastname;

        public Employee(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public string Description()
        {
            return name + " " + lastname + " (" + this.GetType().Name + ")";
        }
    }
}