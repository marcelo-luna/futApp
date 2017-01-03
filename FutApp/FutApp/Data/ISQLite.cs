using SQLite;

namespace FutApp.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
