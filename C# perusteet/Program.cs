using System;

int ritariHp = 50;
int orkkiHp = 60;
Random generaattori = new Random();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Tervetuloa armas ritarimmme autattehan meitä pelastamaan kylämme tältä pahalta örkiltä");
Console.ForegroundColor = ConsoleColor.White;


while (orkkiHp > 0 && ritariHp > 0)
{

    Console.WriteLine("-----------------------------------------------------------------------------------------");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Ritari HP " + ritariHp);
    Console.ForegroundColor = ConsoleColor.White;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Örkki HP " + orkkiHp);
    Console.ForegroundColor = ConsoleColor.White;

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
        int vahinkoPisteet = ArvoVahinko(3, 8);
        orkkiHp -= vahinkoPisteet;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hyökkäät örkin kimppuun ja teit"  + " " + vahinkoPisteet + " " + "vahinko pistettä");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        //protect
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Puolustaudut örkin iskua vastaan");
        Console.ForegroundColor = ConsoleColor.White;
    }

    int orkkiVahinko = ArvoVahinko(3, 6);
    {
        if (komentoNumero == 2)
        {           
            orkkiVahinko /= 2;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("örkki hyökkää kimppuusi ja tekee" + " " + orkkiVahinko + " " + "vahinko pistettä");
        ritariHp -= orkkiVahinko;
        Console.ForegroundColor = ConsoleColor.White;
    }

    
} // vuoroluupin loppu

if (ritariHp <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("-----------------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Sinut päihitettiin.");
    Console.ForegroundColor = ConsoleColor.White;
}
else if (orkkiHp <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("-----------------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Päihitit örkin.");
    Console.ForegroundColor = ConsoleColor.White;
}


int ArvoVahinko(int minimi, int maksimi)
{
    
    return generaattori.Next(minimi, maksimi+1);
}


