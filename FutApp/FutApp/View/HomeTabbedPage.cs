using FutApp.Data;
using FutApp.Model;
using SQLite;
using Xamarin.Forms;

namespace FutApp.View
{
    public class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            SQLiteConnection con = DependencyService.Get<ISQLite>().GetConnection();
            PlayerDAO dao = new PlayerDAO(con);

            CadPlayer cadplayer = new CadPlayer(dao);
            ListaPlayers listaPlayers = new ListaPlayers(dao);

            this.Children.Add(cadplayer);
            this.Children.Add(listaPlayers);
        }
    }
}
