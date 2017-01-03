using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FutApp.Data;
using FutApp.ViewModel;
using Xamarin.Forms;

namespace FutApp.View
{
    public partial class ListaPlayer : ContentPage
    {
        public ListaPlayer(PlayerDAO dao)
        {
            ListaPlayerViewModel vm = new ListaPlayerViewModel(dao, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
