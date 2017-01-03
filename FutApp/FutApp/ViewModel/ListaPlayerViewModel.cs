using System.Collections.ObjectModel;
using FutApp.Data;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;
using FutApp.Model;

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
                status = value;
                OnPropertyChanged("Status");
            }
        }

        public ListaPlayerViewModel(PlayerDAO dao, ContentPage page)
        {
            Player = dao.Lista;
            this.dao = dao;
            this.page = page;
        }

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }
    }
}
