using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Employee
    {
        private int _employeeId;
        private string _name;
        private string _position;
        private decimal _salary;

        public int EmployeeId
        {
            get { return _employeeId; }
            private set
            {
                if (value > 0)
                    _employeeId = value;
                else
                    throw new ArgumentException("Employee ID must be greater than 0.");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be empty.");
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _position = value;
                else
                    throw new ArgumentException("Position cannot be empty.");
            }
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;
                else
                    throw new ArgumentException("Salary cannot be negative.");
            }
        }

        public Employee(int employeeId, string name, string position, decimal salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Position = position;
            Salary = salary;
        }

    }


}
