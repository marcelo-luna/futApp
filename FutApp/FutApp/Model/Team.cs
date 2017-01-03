using SQLite;

namespace FutApp.Model
{
    class Team
    {
        [PrimaryKey, AutoIncrement]
        public int IDTeam { get; set; }
        public int IDPlayer { get; set; }

        public Team(int idplayer)
        {
            this.IDPlayer = idplayer;
        }

        public Team () { }
    }
}
