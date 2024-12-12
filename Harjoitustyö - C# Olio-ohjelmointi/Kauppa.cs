using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyö___C__Olio_ohjelmointi
{

    class Kauppa
    {
        

        public Kauppa()
        {
            
        }

        public void NaytaTavarat(Ritari pelaaja)
        {
            Console.WriteLine("Tervetuloa kauppaan! Sinulla on " + pelaaja.Kulta + " kultaa.");
            Console.WriteLine("Valitse tavara:");
            Console.WriteLine("1. Miekka - 10 kultaa");
            Console.WriteLine("2. Haarniska - 20 kultaa");
            Console.WriteLine("3. Taikajuoma - 5 kultaa");
        }

        public void OstaTavara(Ritari pelaaja, int valinta)
        {
            switch (valinta)
            {
                case 1:
                    if (pelaaja.Kulta >= 10)
                    {
                        pelaaja.VahennaKultaa(10);
                        Console.WriteLine("Ostit miekan!");
                        pelaaja.ase = new Ase();
                    }
                    else
                    {
                        Console.WriteLine("Sinulla ei ole tarpeeksi kultaa!");
                    }
                    break;
                case 2:
                    if (pelaaja.Kulta >= 20)
                    {
                        pelaaja.VahennaKultaa(20);
                        Console.WriteLine("Ostit haarniskan!");
                        pelaaja.haarniska = new Haarniska(3);
                    }
                    else
                    {
                        Console.WriteLine("Sinulla ei ole tarpeeksi kultaa!");
                    }
                    break;
                case 3:

                    if (pelaaja.Kulta >= 5)
                    {
                        bool täynnä = true;
                        for (int i = 0; i < pelaaja.taikajuomat.Length; i++)
                        {
                            if (pelaaja.taikajuomat[i] == null)
                            {
                               
                                täynnä = false;
                                pelaaja.taikajuomat[i] = new Taikajuoma();
                                pelaaja.VahennaKultaa(5);
                                Console.WriteLine("Ostit taikajuoman!");
                                break;

                            }

                            // Esine valittuEsine = ValitseEsine();


                        }
                        if (täynnä == true)
                        {
                            Console.WriteLine("Taikajuomia on liikaa");
                        }
                        
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("Sinulla ei ole tarpeeksi kultaa!");
                    }
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta!");
                    break;
            }
            
               
        }
        

       
    }
}

    

