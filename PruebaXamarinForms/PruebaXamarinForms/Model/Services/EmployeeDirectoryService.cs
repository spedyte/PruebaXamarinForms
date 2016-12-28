using PruebaXamarinForms.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXamarinForms.Model.Services
{
    public class EmployeeDirectoryService
    {

        public static EmployeeDirectory LoadEmployeeDirectory()
        {


            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            EmployeeDirectory employeeDirectory = new EmployeeDirectory();


            employees = new ObservableCollection<Employee>();

            string[] names = { "Armando", "Emmanuel", "José Noel", "David","Jorge",
                                "Luisa", "Isabel", "Fernanda", "Mercedes", "Ximena"};
            string[] lastNames = { "Flores", "Benitez", "Morgado", "Roblero", "Bautista","Zamora" };

            string[] positions = {"Administrador" , "Contador", "Progamador" , "Analista" , "Tester" };

            Random rdn = new Random(DateTime.Now.Millisecond);

            employees = new ObservableCollection<Employee>();

            for (int i = 0; i < 20; i++)
            {
                Employee employee = new Employee();
                employee.Name = names[rdn.Next(0, 8)];
                employee.LastName = $"{lastNames[rdn.Next(0, 5)]} {lastNames[rdn.Next(0, 5)]}";
                employee.EmployeePosition= positions[rdn.Next(0, 5)];
                employee.EmployeeNumber = rdn.Next(12384748, 32384748).ToString();
                employees.Add(employee);

            }
            employeeDirectory.Employees= employees;
            return employeeDirectory;
        }

    }
}
