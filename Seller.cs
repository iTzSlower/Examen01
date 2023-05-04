using System;
using System.Collections.Generic;
using System.Text;

namespace Examen01
{
    class Seller : NPC
    {
        public int money;
        public List<Items> Items = new List<Items>();
        public Seller(int n)
        {
            this.money = n;
        }
        public override string ShowData()
        {
            return $"tipo: vendedor, dinero : {money}, vende {Items.Count} objetos";
        }
        public void AddItem(Items item)
        {
            Items.Add(item);
        }
    }
}
