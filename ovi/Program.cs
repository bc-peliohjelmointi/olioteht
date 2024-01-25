class Ovi
{
    public static void Main()
    {
      Ovi Olio = new Ovi();
        Olio.Run();
    }
    enum OvenTila
    {
        auki,
        kiinni,
        lukossa
    }
    public void Run()
    {
        OvenTila oventila = OvenTila.auki;
        while (true)
        {


            string komento;
            while (true)
            {
                Console.WriteLine("ovi on " + oventila);
                Console.WriteLine("Anna komento: avaa, sulje, lukitse, avaa lukko");
                komento = Console.ReadLine();
                if (komento == "avaa" || komento == "sulje" || komento == "lukitse" || komento == "avaa lukko")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Komentoa ei tunnistettu");
                }
            }

            if (komento == "avaa")
            {
                if (oventila == OvenTila.kiinni)
                {
                    Console.WriteLine("Avasit oven");
                    oventila = OvenTila.auki;
                }
            }
            else if (komento == "sulje")
            {
                if (oventila == OvenTila.auki)
                {
                    Console.WriteLine("Suljit oven");
                    oventila = OvenTila.kiinni;
                }
            }
            else if (komento == "lukitse")
            {
                if(oventila == OvenTila.kiinni)
                {
                    Console.WriteLine("Lukitsit oven");
                    oventila = OvenTila.lukossa;
                }
            }
            else if (komento == "avaa lukko")
            {
                if (oventila == OvenTila.lukossa)
                {
                    Console.WriteLine("Avasit lukon");
                    oventila = OvenTila.kiinni;
                }
            }


        }
    }
}






