using System;

public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }

        public override string ToString() =>
            $"{Name}, {Department}, {Age}";
    }

//Builder Pattern is used to construct a complex object step by step.
//It allows you to create different types and representations of an object using the same construction code. properties and optional parameters can be set in a flexible way.
public class EmployeeBuilder
    {
        private readonly Employee _employee = new Employee();

        public EmployeeBuilder SetName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public EmployeeBuilder SetDepartment(string department)
        {
            _employee.Department = department;
            return this;
        }

        public EmployeeBuilder SetAge(int age)
        {
            _employee.Age = age;
            return this;
        }

        public Employee Build() => _employee;
    }


