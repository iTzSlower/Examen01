using System;
using System.Collections.Generic;
using System.Text;

namespace Examen01
{
    class Potion : Items
    {
        string type;
        string name;
        int cost;
        int capacidad = 3;
        public Potion(string type,string name,int cost) : base(type,name,cost)
        {
            this.type = type;
            this.name = name;
            this.cost = cost;
        }
        public override string ShowData()
        {
            return $"tipo {type}, nombre : {name}, costo: {cost}";
        }
    }
}
