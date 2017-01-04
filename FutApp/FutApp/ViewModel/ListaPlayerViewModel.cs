using System.Collections.ObjectModel;
using FutApp.Data;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;
using FutApp.Model;
using System;
using System.Linq;

namespace FutApp.ViewModel
{
    public class ListaPlayerViewModel : INotifyPropertyChanged
    { 
    
        private PlayerDAO dao;
        private ContentPage page;
        public ObservableCollection<Player> Player { get; set; } 

        public ICommand UpdatePlayer { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private bool status;

        public bool Status
        {
            get { return status; }
            set
            {
                if (value != status)
                {
                    status = value;
                    OnPropertyChanged("Status");
                    //dao.update(Player.);
                }
            }
        }

        public ListaPlayerViewModel(PlayerDAO dao, ContentPage page)
        {
            Player = dao.Lista;
            this.dao = dao;
            this.page = page;

            UpdatePlayer = new Command(() =>
            {
                /*Player player = new Player(Player.);
                dao.save(player);
                page.DisplayAlert("Salvar Jogador", $"Jogador {name} salvo com sucesso!", "OK")
                ;*/
            });
        }

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }
    }
}
