
class Teht1
{
    static void Main(String[] args)
    {
        Oventila oventilaNyt = Oventila.auki;
        Console.WriteLine(oventilaNyt);
        Console.WriteLine("Anna toimnto!: avaa, sulje, lukitse, avaa lukko");
        string toiminto = Console.ReadLine();

        if (toiminto == "avaa")
        {
            
        }
        if (toiminto == "sulje")
        {

        }
        if (toiminto == "lukitse")
        {

        }
        if (toiminto == "avaa lukko")
        {

        }
       
    }
              
    enum Oventila
    {
        auki, kiinni, lukossa
    }
    
   
   
}








