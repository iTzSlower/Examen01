using System;
using System.Collections.Generic;
using System.Text;

namespace Examen01
{
    class Talkers : NPC
    {
        string name;
        public List<string> text = new List<string>();
        public Talkers(string name)
        {
            this.name = name;
        }
        public override string ShowData()
        {
            return $"tipo: conversador, nombre: {name}, tiene {text.Count} dialogos";
        }
        public void AddDialog(string dialog)
        {
            text.Add(dialog);
        }
    }
}
