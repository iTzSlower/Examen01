using System;
using System.Collections.Generic;
using System.Text;

namespace Examen01
{
    abstract class NPC : IShowData
    {
        public virtual string ShowData()
        {
            return "NPC vacio";
        }
    }
}
