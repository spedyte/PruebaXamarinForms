using PruebaXamarinForms.Model.Entities;
using PruebaXamarinForms.Model.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PruebaXamarinForms.ViewModel
{
    class EmployeeDirectoryVM : ObservableBaseObject
    {
        public ObservableCollection<Employee> Employees{ get; set; }

        bool isBusy = false;

        public bool IsBusy { get { return isBusy; } set { isBusy = value; OnPropertyChanged(); } }

        public Command LoadDirectoryCommand { get; set; }

        public EmployeeDirectoryVM()
        {
            Employees = new ObservableCollection<Employee>();
            IsBusy = false;
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());
        }

        async void LoadDirectory()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Task.Delay(3000);

                var loadedDirectory = EmployeeDirectoryService.LoadEmployeeDirectory();

                foreach (var employee in loadedDirectory.Employees)
                {
                    Employees.Add(employee);
                }

                IsBusy = false;
            }
        }
    }
}
