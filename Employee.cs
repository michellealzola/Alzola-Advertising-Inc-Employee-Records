using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    internal class Employee
    {
        private string _name;
        private string _idNumber;
        private string _department;
        private string _position;

        public Employee(string name, string idNumber, string department, string position)
        {
            _name = name;
            _idNumber = idNumber;
            _department = department;
            _position = position;
        }

        public Employee(string name, string idNumber)
        {
            _name = name;
            _idNumber = idNumber;
            _department = "";
            _position = "";
        }

        public Employee()
        {
            _name = "";
            _idNumber = "";
            _department = "";
            _position = "";
        }

        public string Name { get { return _name; } }

        public string IdNumber { get { return _idNumber; } }

        public string Department { get { return _department; } }

        public string Position { get { return _position; } }


    }
}
