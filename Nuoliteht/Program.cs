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
            Console.WriteLine("Tervetuloa nuolikauppaan");
            Nuolenkärki valittukärki;
            Nuolensulka valittusulka;
            int valittupituus = 0;

            while (true)
            {
                Console.WriteLine("Millainen kärki? (puu, teräs, timantti");
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
                        Console.WriteLine("Pituus ei ole mahdollinen");
                    }
                }
            }
            Nuoli uusinuoli = new Nuoli(valittukärki, valittusulka, valittupituus);
            Console.WriteLine("Ostit nuolen jonka hinta on " + uusinuoli.Laskehinta());
            Console.WriteLine("nuolen kärki on " + uusinuoli.GetKärkiosa());
            Console.WriteLine("nuolen sulka on " + uusinuoli.GetNuolensulka());
            Console.WriteLine("nuolen pituus on " + uusinuoli.Getpituus());
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

    public class Nuoli
    {
        Nuolenkärki kärkiOsa;
        Nuolensulka sulkaOsa;
        int pituusCm;
        public Nuoli(Nuolenkärki kärkiOsa, Nuolensulka sulkaOsa, int pituusCm)
        {
            this.kärkiOsa = kärkiOsa;
            this.sulkaOsa = sulkaOsa;
            this.pituusCm = pituusCm;
        }

        public Nuolenkärki GetKärkiosa()
        {
            return kärkiOsa;
        }
        
        public Nuolensulka GetNuolensulka()
        {
            return sulkaOsa;
        }
        public int Getpituus()
        {
            return pituusCm;
        }
       
        public float Laskehinta()
        {
            float hinta = 0;
            if(this.kärkiOsa == Nuolenkärki.puu)
            {
                hinta += 3;
            }
            if (this.kärkiOsa == Nuolenkärki.teräs)
            {
                hinta += 5;
            }
            if (this.kärkiOsa == Nuolenkärki.timantti)
            {
                hinta += 50;
            }
            

            if(this.sulkaOsa == Nuolensulka.lehti)
            {
                hinta += 0;
            }
            if (this.sulkaOsa == Nuolensulka.kanansulka)
            {
                hinta += 1;
            }
            if (this.sulkaOsa == Nuolensulka.kotkansulka)
            {
                hinta += 5;
            }

            hinta += this.pituusCm * 0.05f;

            return hinta;
        }
    }
}