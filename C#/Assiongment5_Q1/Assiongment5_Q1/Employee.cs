﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_Q2
{
    public class Employee
    {
        public int empId;
        public string empName;
        public double salary;

        public Employee(int empId, string empName, double salary)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Employee ID: {empId}\nEmployee Name: {empName}\nEmployee Salary:";
        }
    }
}
