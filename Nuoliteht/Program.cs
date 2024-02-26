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
            Console.WriteLine("Ostit nuolen jonka hinta on " + uusinuoli.Laskehinta()+ " kultaa");
            Console.WriteLine("nuolen kärki on " + uusinuoli.Kärkiosa);
            Console.WriteLine("nuolen sulka on " + uusinuoli.Nuolensulka);
            Console.WriteLine("nuolen pituus on " + uusinuoli.pituus);
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
    }
}