using System;

int ritariHp = 30;
int örkkiHp = 30;
Random generaattori = new Random();

Console.WriteLine("Tervetuloa armas ritarimmme autattehan meitä päihittämään tämän suuren pahan örkin");



while (örkkiHp > 0 && ritariHp > 0)
{

    Console.WriteLine("-----------------------------------------------------------------------------------------");

    Console.WriteLine("pelaaja HP " + ritariHp);
    Console.WriteLine("vastustaja HP " + örkkiHp);

    Console.WriteLine("1: Hyökkää");
    Console.WriteLine("2: Puolusta");

    int komentoNumero = 0;
    while (true)
    {
        string komento = Console.ReadLine();
        komentoNumero = int.Parse(komento);
        if (komentoNumero == 1)
        {
            break;
        }
        else if (komentoNumero == 2)
        {
            break;
             
        }
    }

    if (komentoNumero == 1)
    {
        // Attac
        int vahinkoPisteet = ArvoVahinko(1, 6);
        örkkiHp -= vahinkoPisteet;
        Console.WriteLine("Hyökkäät örkin kimppuun");
    }
    else
    {
        //protect
        Console.WriteLine("Puolustaudut örkin iskua vastaan");
    }

    int örkkiVahinko = ArvoVahinko(1, 6);
    {
        if (komentoNumero == 2)
        {
            örkkiVahinko /= 2;
        }
        ritariHp -= örkkiVahinko;
    }

    
} // vuoroluupin loppu

if (ritariHp <= 0)
{
    Console.WriteLine("Sinut päihitettiin.");
}
else if (örkkiHp <= 0)
{
    Console.WriteLine("Päihitit örkin.");
}

int ArvoVahinko(int minimi, int maksimi)
{
    return generaattori.Next(minimi, maksimi+1);
}


