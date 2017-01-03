using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FutApp.Model
{
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int IDPlayer { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public int Level { get; set; }
        public bool Status { get; set; }

        public Player(string name, int postion, int level, bool status)
        {
            this.Name = name;
            this.Position = postion;
            this.Level = level;
            this.Status = status;
        }

        public Player () { }
    }
}
