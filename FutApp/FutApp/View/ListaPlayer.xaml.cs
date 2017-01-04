using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FutApp.Data;
using FutApp.Model;
using FutApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FutApp.View
{
    public partial class ListaPlayer : ContentPage
    {
        private ListaPlayerViewModel vm;
        public ListaPlayer(PlayerDAO dao)
        {
            vm = new ListaPlayerViewModel(dao, this);
            this.BindingContext = vm;
            InitializeComponent();
        }
        
        private void Cell_OnTapped(object sender, EventArgs e)
        {
            try
            {
                    vm.Status = (sender as SwitchCell).On ;
            }
            catch (Exception)
            {
            }
           // throw new NotImplementedException();
        }
    }
}
