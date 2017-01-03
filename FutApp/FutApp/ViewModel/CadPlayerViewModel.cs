using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FutApp.Data;
using Xamarin.Forms;
using FutApp.Model;

namespace FutApp.ViewModel
{
    public class CadPlayerViewModel : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }

            set
            {
                if (value != name)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }


        private int position;
        public int Position
        {
            get { return position; }

            set
            {
                if (value != position)
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }

        private int level;
        public int Level
        {
            get { return level; }

            set
            {
                if (value != level)
                {
                    level = value;
                    OnPropertyChanged("Level");
                }
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
                }
            }
        }

        public ICommand SavePlayer { get; private set; }

        private PlayerDAO dao;
        private ContentPage page;

        public CadPlayerViewModel(PlayerDAO dao, ContentPage page)
        {
            this.dao = dao;
            this.page = page;

            SavePlayer = new Command(() =>
            {
                Player player = new Player(name, position, level, status);
                dao.save(player);
                page.DisplayAlert("Salvar Jogador", $"Jogador {name} salvo com sucesso!", "OK")
                ;
                clear();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }

        private void clear()
        {
            Name = string.Empty;
            Position = 0;
            Level = 0;
            Status = false;
        }
    }
}
