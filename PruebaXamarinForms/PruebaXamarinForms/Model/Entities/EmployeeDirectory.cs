using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXamarinForms.Model.Entities
{
    public class EmployeeDirectory
    {
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees {
            get { return employees; }
            set { employees = value; }
        }
    }
}
