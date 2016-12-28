using PruebaXamarinForms.Model.Entities;
using PruebaXamarinForms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PruebaXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new EmployeeDirectoryVM();
            lvEmployees.ItemSelected += lvEmployees_ItemSelected;
        }

        void lvEmployees_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Employee selectedEmployee = (Employee)e.SelectedItem;
            if (selectedEmployee == null)
                return;
            Navigation.PushAsync(new EmployeeDetail(selectedEmployee));
            lvEmployees.SelectedItem = null;
        }
    }
}
