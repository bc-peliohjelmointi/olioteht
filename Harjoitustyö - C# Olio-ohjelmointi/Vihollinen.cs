using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyö___C__Olio_ohjelmointi
{
    class Vihollinen
    {
        protected int vahinko;
        public int hp {  get; private set; }
        public string nimi;
        public Vihollinen(string nimi, int vahinko, int hp = 20)
        {
            this.nimi = nimi;
            this.vahinko = vahinko;
            this.hp = hp;
        }

        

        public void VahennaHP(int maara)
        {
            hp -= maara;
            Console.WriteLine($"{nimi} sai {maara} vahinkoa on nyt " + hp + " HP.");
        }

        public void Iske(Ritari pelaaja)
        {
            
            Console.WriteLine($"{nimi} hyökkää");
            pelaaja.VahennaHP(vahinko);
            
        }
    }
}
