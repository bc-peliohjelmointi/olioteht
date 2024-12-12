namespace Harjoitustyö___C__Olio_ohjelmointi
{
    internal class Program
    {
        Ritari pelaaja = new Ritari();
        public static void Main(string[] args)
        {
            Program peli = new Program();
            peli.Run();
        }

        public void Run()
        {


            while (pelaaja.hp > 0)
            {


                Console.WriteLine("Valitse toiminto:");
                Console.WriteLine("1. Mene kauppaan");
                Console.WriteLine("2. Hyökkää vihollista vastaan");
                int valinta = Convert.ToInt32(Console.ReadLine());

                if (valinta == 1)
                {
                    pelaaja.MeneKauppaan();
                }
                else if (valinta == 2)
                {
                    Fight();
                }
            }


        }

        public enum TappeluToiminto
        {
            Iske,
            Esine,
            Pakene
        }
        public void Fight()
        {
            Random rnd = new Random();
            Vihollinen vihollinen;
            int valittu = rnd.Next(1, 4);
            if (valittu == 1)
            {
                vihollinen = new Goblin();
            }
            else if (valittu == 2)
            {
                vihollinen = new Haltia();
            }
            else
            {
                vihollinen = new Loordi();
            }

            bool pelaajaElossa = pelaaja.hp > 0;
            bool vihollinenElossa = vihollinen.hp > 0;

            while (pelaajaElossa && vihollinenElossa)
            {
                TappeluToiminto taisteluValinta = TeeTaisteluValinta();
                switch (taisteluValinta)
                {
                    case TappeluToiminto.Iske:


                        pelaaja.GetAttackDamage(vihollinen);

                        break;

                    case TappeluToiminto.Esine:
                        bool löytyi = false;
                        for (int i = 0; i < pelaaja.taikajuomat.Length; i++)
                        {
                            if (pelaaja.taikajuomat[i] != null)
                            {
                                pelaaja.Paranna(pelaaja.taikajuomat[i]);
                                löytyi = true;
                                pelaaja.taikajuomat[i] = null;
                                break;
                            }
                            
                            // Esine valittuEsine = ValitseEsine();
                            

                        }
                        if (löytyi == false)
                        {
                            Console.WriteLine("Ei ole taikajuomaa");
                        }
                        break;
                    case TappeluToiminto.Pakene:


                        break;

                        

                }
                vihollinen.Iske(pelaaja);

                pelaajaElossa = pelaaja.hp > 0;
                vihollinenElossa = vihollinen.hp > 0;

               if( taisteluValinta == TappeluToiminto.Pakene)
                {
                    break;
                }

                
            }
            if(pelaajaElossa && !vihollinenElossa)
            {
                pelaaja.LisaaKultaa(10);

            }

        }
        public TappeluToiminto TeeTaisteluValinta()
        {
            while (true)
            {


                Console.WriteLine("1. Iske vihollista");
                Console.WriteLine("2. Kaytä esinettä");
                Console.WriteLine("3. Pakene");
                string valinta = Console.ReadLine();
                if (valinta == "1") { return TappeluToiminto.Iske; };
                if (valinta == "2") { return TappeluToiminto.Esine; };
                if (valinta == "3") { return TappeluToiminto.Pakene; };
            }
        }
    }
}