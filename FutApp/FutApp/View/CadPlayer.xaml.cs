using FutApp.Data;
using FutApp.ViewModel;
using Xamarin.Forms;
using System;

namespace FutApp.View
{
    public partial class CadPlayer : ContentPage
    {
        public CadPlayer(PlayerDAO dao)
        {
            CadPlayerViewModel vm = new CadPlayerViewModel(dao, this);
            BindingContext = vm;
            InitializeComponent();

            positionPlayer.Items.Add("Goleiro");
            positionPlayer.Items.Add("Zagueiro");
            positionPlayer.Items.Add("Meia");
            positionPlayer.Items.Add("Atacante");
        }
    }
}
