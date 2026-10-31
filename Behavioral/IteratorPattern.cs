using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Behavioral
{
    internal class IteratorPattern
    {
        public class EmployeeCollection
        {
            private readonly List<string> _employees = new();

            public void Add(string employee) => _employees.Add(employee);

            public IEnumerable<string> GetEmployees()
            {
                foreach (var employee in _employees)
                    yield return employee;
            }
        }

    }
}
