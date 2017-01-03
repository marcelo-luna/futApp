
using System.Collections.ObjectModel;
using FutApp.Model;
using SQLite;
using System;

namespace FutApp.Data
{
    public class PlayerDAO
    {
        private SQLiteConnection conexao;
        private ObservableCollection<Player> lista;

        public ObservableCollection<Player> Lista
        {
            get
            {
                if (lista == null)
                {
                    lista = GetAll();
                }
                return lista;
            }
            private set { Lista = value; }
        }

        public PlayerDAO(SQLiteConnection con)
        {
            conexao = con;
            conexao.CreateTable<Player>();
        }

        private ObservableCollection<Player> GetAll()
        {
            return new ObservableCollection<Player>(conexao.Table<Player>());
        }

        public void save(Player player)
        {
            try
            {
                conexao.Insert(player);
                lista.Add(player);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
