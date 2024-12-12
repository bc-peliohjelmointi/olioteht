using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeikkailijanReppu
{
    internal class Reppu
    {
        public float maksimiTilavuus { get; set; }
        public float maksimiPaino { get; set; }

        Tavara[] tavarat;
        int uusinIndeksi;
        public Reppu(int maksimiMääräYhteensä, float maksimiPaino, float maksimiTilavuus) 
        {
            tavarat = new Tavara[maksimiMääräYhteensä];
            uusinIndeksi = 0;

            this.maksimiPaino = maksimiPaino;
            this.maksimiTilavuus = maksimiTilavuus;
        }
        public bool Lisäätavara(Tavara tavara)
        {
            tavarat[uusinIndeksi] = tavara;
            uusinIndeksi += 1;
            return true;
        }
        public static void Run()
        {
            Reppu reppu = new Reppu(20, 100, 100);

            while(true)
            {
                reppu.TulostaTilanne();
                Console.WriteLine("Mitä haluat lisätä");
                Console.WriteLine("1: Nuoli");
                Console.WriteLine("2: Jousi");
                Console.WriteLine("3: Köysi");
                Console.WriteLine("4: Vesi");
                Console.WriteLine("5: Ruoka");
                Console.WriteLine("6: Miekka");
                string vastaus = Console.ReadLine();
                Tavara uusiTavara = null;

                if(vastaus == "1")
                {
                    uusiTavara = new Nuoli();
                }

                if(vastaus == "2")
                {
                    uusiTavara = new Jousi();
                }
                if(vastaus == "3")
                {
                    uusiTavara = new Köysi();
                }
                if(vastaus == "4")
                {
                    uusiTavara = new Vesi();
                }
                if(vastaus == "5")
                {
                    uusiTavara = new Ruoka_Annos();
                }
                if (vastaus == "6")
                {
                    uusiTavara = new Miekka();
                }

                bool lisätty = reppu.Lisäätavara(uusiTavara);
                if (lisätty == false)
                {
                    Console.WriteLine("Ei kelpaa");
                }
            }

            
        }

        public void TulostaTilanne()
        {
            for (int i = 0; i < uusinIndeksi; i++) 
            {
                Console.WriteLine($"Tavara{i + 1}: {tavarat[i].ToString()}");
            }
        }

       
    }
}
