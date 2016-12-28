using PruebaXamarinForms.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PruebaXamarinForms
{
    public partial class EmployeeDetail : ContentPage
    {
        public EmployeeDetail(Employee selectedEmployee)
        {
            InitializeComponent();
            this.BindingContext = selectedEmployee;
        }
    }
}
