using System;
using System.Collections.Generic;
using System.Text;

namespace Examen01
{
    abstract class Items : IShowData
    {
        protected string name;
        protected string type;
        protected int cost;
        protected Items(string type,string name,int cost)
        {
            this.type = type;
            this.name = name;
            this.cost = cost;
        }
        public virtual string ShowData()
        {
            return "Item vacio";
        }
    }
}
