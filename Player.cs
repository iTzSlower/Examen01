using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01
{
    class Player : IShowData
    {
        public int health = 100;
        public string name;
        public List<Items> Items = new List<Items>();
        public float exp;
        public int level;

        public Player(string n ,float e,int l)
        {
            this.name = n;
            this.exp = e;
            this.level = l;
        }
        public string ShowData()
        {
            return $"mi nombre es {this.name}, soy nivel {this.level} con {this.exp} puntos de experiencia y tengo un total de {health} puntos de vida";
        }
        public void AddItem(Items item)
        {
            Items.Add(item);
        }
    }
}
