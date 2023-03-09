using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }
        public Inventory inventory { get; set; }
        public Employee()
        {
            inventory = new Inventory();
        }
        public abstract void get_salary(int Id);


    }
}

