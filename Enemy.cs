using System;
using System.Collections.Generic;
using System.Text;

namespace Examen01
{
    class Enemy : NPC
    {
        public string name;
        public float damage;
        public int level;
        public float expG;
        public List<Items> Items = new List<Items>();
        public Enemy(string n, float d, float e, int l)
        {
            this.name = n;
            this.damage = d;
            this.expG = e;
            this.level = l;
        }
        public override string ShowData()
        {
            return $"nombre : {name}, daño : {damage}, nivel {level}, experiencia que da{expG}";
        }
        public void AddItem(Items item)
        {
            Items.Add(item);
        }
    }
}
