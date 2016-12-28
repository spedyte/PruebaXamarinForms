using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXamarinForms.Model.Entities
{
    public class Employee : ObservableBaseObject
    {
        private string name;
        public string Name { get { return name; }
            set { name = value; OnPropertyChanged(); } }


        private string lastName;
        public string LastName { get { return lastName; }
            set { lastName = value; OnPropertyChanged(); } }

        private string employeeNumber;
        public string EmployeeNumber { get { return employeeNumber; }
            set { employeeNumber = value; OnPropertyChanged(); } }

        private string employeePosition;
        public string EmployeePosition { get { return employeePosition; }
            set { employeePosition = value; OnPropertyChanged(); } }

    }
}
