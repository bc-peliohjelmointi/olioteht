using System.Security.Cryptography.X509Certificates;

namespace Nuoliteht
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Program tehtävä = new Program();
            tehtävä.Run();                               
        }
        public void Run()
        {
            Valinta annettuVastaus;
            bool suunnittelu = false;
            Console.WriteLine("Tervetuloa nuolikauppaan");
            Console.WriteLine("Hei, haluatko ostaa: eliittinuoli, aloittelijanuoli, perusnuoli, vai suunnittelu.");

            while (true)
            {
               

                string vastaus = Console.ReadLine();
                if (Enum.TryParse<Valinta>(vastaus, out annettuVastaus))
                {
                    if(annettuVastaus == Valinta.eliittinuoli)
                    {
                        Nuoli eliititnuoli = Nuoli.LuoEliittiNuoli();
                        Console.WriteLine("Ostit eliittinuolen jonka hinta on " + eliititnuoli.Laskehinta() + " kultaa"); 
                        Console.WriteLine("nuolen kärki on " + eliititnuoli.Kärkiosa.ToString());
                        Console.WriteLine("nuolen sulka on " + eliititnuoli.Nuolensulka.ToString());
                        Console.WriteLine("nuolen pituus on " + eliititnuoli.pituus + "cm");
                    }
                    else if (annettuVastaus == Valinta.aloittelijanuoli)
                    {
                        Nuoli aloittelijan = Nuoli.LuoAloittelijaNuoli();
                        Console.WriteLine("Ostit aloittelijanuolen jonka hinta on " + Nuoli.LuoAloittelijaNuoli().Laskehinta() + " kultaa");
                        Console.WriteLine("nuolen kärki on " + aloittelijan.Kärkiosa.ToString());
                        Console.WriteLine("nuolen sulka on " + aloittelijan.Nuolensulka.ToString());
                        Console.WriteLine("nuolen pituus on " + aloittelijan.pituus);
                    }
                    else if (annettuVastaus == Valinta.perusnuoli)
                    {
                        Nuoli perus = Nuoli.LuoEliittiNuoli();
                        Console.WriteLine("Ostit perusnuolen jonka hinta on " + Nuoli.LuoPerusNuoli().Laskehinta() + " kultaa");
                        Console.WriteLine("nuolen kärki on " + perus.Kärkiosa.ToString());
                        Console.WriteLine("nuolen sulka on " + perus.Nuolensulka.ToString());
                        Console.WriteLine("nuolen pituus on " + perus.pituus);
                    }

                    else if (annettuVastaus == Valinta.suunnittelu)
                    {
                        suunnittelu = true;
                    }
                    break;
                }
                    else
                    {
                    Console.WriteLine("En ymmärrä vastausta");
                    }
                }


            if (suunnittelu)
            {

                
                Nuolenkärki valittukärki;
                Nuolensulka valittusulka;
                int valittupituus = 0;



                while (true)
                {
                    Console.WriteLine("Millainen kärki? (puu, teräs, timantti)");
                    string kärkivastaus = Console.ReadLine();
                    if (Enum.TryParse<Nuolenkärki>(kärkivastaus, out valittukärki))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("En ymmärrä valintaasi");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Minkälainen sulka? (lehti, kanansulka, kotkansulka)");
                    string sulkavastaus = Console.ReadLine();
                    if (Enum.TryParse<Nuolensulka>(sulkavastaus, out valittusulka))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("En ymmärrä valintaasi");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Nuolen pituus senttimetreissä? (60-100)");
                    string pituusvastaus = Console.ReadLine();

                    if (int.TryParse(pituusvastaus, out valittupituus))
                    {
                        if (valittupituus >= 60 && valittupituus <= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Tämä ei ole mahdollinen");
                        }
                    }
                }
                Nuoli uusinuoli = new Nuoli(valittukärki, valittusulka, valittupituus);
                Console.WriteLine("Ostit nuolen jonka hinta on " + uusinuoli.Laskehinta() + " kultaa");
                Console.WriteLine("nuolen kärki on " + uusinuoli.Kärkiosa);
                Console.WriteLine("nuolen sulka on " + uusinuoli.Nuolensulka);
                Console.WriteLine("nuolen pituus on " + uusinuoli.pituus + "cm");
            }
        }
    }

    public enum Nuolenkärki
    {
        puu,
        teräs,
        timantti
    }

    public enum Nuolensulka
    {
        lehti,
        kanansulka,
        kotkansulka
    }
    public enum Valinta
    {
        eliittinuoli, 
        aloittelijanuoli, 
        perusnuoli,
        suunnittelu
    }


    public class Nuoli
    {
        public Nuoli(Nuolenkärki kärkiOsa, Nuolensulka sulkaOsa, int pituusCm)
        {
            this.Kärkiosa = kärkiOsa;
            this.Nuolensulka = sulkaOsa;
            this.pituus = pituusCm;
        }

        public Nuolenkärki Kärkiosa
        {
            get;
            private set;
           
        }
        
        public Nuolensulka Nuolensulka
        {
            get;
            private set;
        }

        public int pituus
        {
            get;
            private set;
           
        }
       
        public float Laskehinta()
        {
            float hinta = 0;
            if(this.Kärkiosa == Nuolenkärki.puu)
            {
                hinta += 3;
            }
            if (this.Kärkiosa == Nuolenkärki.teräs)
            {
                hinta += 5;
            }
            if (this.Kärkiosa == Nuolenkärki.timantti)
            {
                hinta += 50;
            }
            

            if(this.Nuolensulka == Nuolensulka.lehti)
            {
                hinta += 0;
            }
            if (this.Nuolensulka == Nuolensulka.kanansulka)
            {
                hinta += 1;
            }
            if (this.Nuolensulka == Nuolensulka.kotkansulka)
            {
                hinta += 5;
            }

            hinta += this.pituus * 0.05f;

            return hinta;
        }
        public static Nuoli LuoEliittiNuoli()
        {
            Nuoli eliittiNuoli = new Nuoli(Nuolenkärki.timantti, Nuolensulka.kotkansulka, 100);
            return eliittiNuoli;
        }
        public static Nuoli LuoAloittelijaNuoli()
        {
            Nuoli aloittelijaNuoli = new Nuoli(Nuolenkärki.puu, Nuolensulka.kanansulka, 70);
            return aloittelijaNuoli;
        }
        public static Nuoli LuoPerusNuoli()
        {
            Nuoli perusNuoli = new Nuoli(Nuolenkärki.teräs, Nuolensulka.kanansulka, 85);
            return perusNuoli;
        }

    }
}