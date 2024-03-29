﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioList
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public void increaseSalary(double percentage)
        {
            Salary += Salary * percentage;
        }
        public Employee()
        {
            
        }
      
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Id + ", " +Name + ", "+ Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
