using SQLite;
using FutApp.Data;
using Xamarin.Forms;
using FutApp.Droid;

[assembly : Dependency(typeof(SQLiteDroid))]
namespace FutApp.Droid
{
    public class SQLiteDroid : ISQLite
    {
        public SQLiteDroid()
        {
        }

        public SQLiteConnection GetConnection()
        {
            string applicationFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Refeicao.db");
            System.IO.Directory.CreateDirectory(applicationFolderPath);

            string databaseFileName = System.IO.Path.Combine(applicationFolderPath, "FutApp.db");
            var db = new SQLiteConnection(databaseFileName);
            return new SQLiteConnection(databaseFileName);
        }
    }
}