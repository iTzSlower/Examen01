using System;
using System.Collections.Generic;
using System.Text;

namespace Examen01
{
    class Weapon : Items
    {
        string type;
        int damage;
        string name;
        int cost;
        public Weapon(string type, string name, int cost, int damage) : base(type, name, cost)
        {
            this.type = type;
            this.name = name;
            this.cost = cost;
            this.damage = damage;
        }
        public override string ShowData()
        {
            return $"tipo {type}, nombre : {name}, costo: {cost}, damage: {damage}";
        }
    }
}
