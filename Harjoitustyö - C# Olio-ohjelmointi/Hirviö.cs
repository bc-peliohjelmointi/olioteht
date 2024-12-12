using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyö___C__Olio_ohjelmointi
{
    class Hirvio : Vihollinen
    {
        public Hirvio(string nimi, int vahinko, int hp) : base(nimi, vahinko, hp)
        {
        }

        
       
    }

    class Goblin : Hirvio
    {
        public Goblin() : base("Goblin", 5, 20)
        {
        }
    }

    class Haltia : Hirvio
    {
        public Haltia() : base("Haltia", 10, 30)
        {
        }
    }

    class Loordi : Hirvio
    {
        public Loordi() : base("Loordi", 15, 40)
        {
        }
    }
}
