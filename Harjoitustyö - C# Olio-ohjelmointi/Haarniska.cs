using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyö___C__Olio_ohjelmointi
{
    class Haarniska
    {
        public int Vahvuus {  get; set; }

       

        public Haarniska(int Vahvuus)
        {
            this.Vahvuus = Vahvuus;
            if (this.Vahvuus <= 0) 
            { 
                this.Vahvuus = 1;
            }
        }
    }   
}
