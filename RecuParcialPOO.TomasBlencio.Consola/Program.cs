using RecuParcialPOO.TomasBlencio.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        //Punto 01

        PrismaRectangularRecto prisma=new PrismaRectangularRecto(5,10,5);
        Console.WriteLine(prisma.MostrarDatos(prisma));

        //Punto 03
        
        Console.WriteLine(Horoscopo.SignoZodiacal(new DateTime(1998, 02, 22)));
        Console.WriteLine(Horoscopo.SignoChino(1998));
        

        //Punto 04

        Kilo kilo = new Kilo(10);
        Libra libra= new Libra(10);

        //Conversion Implicita
        double doubleKilo = kilo;
        double doubleLibra = libra;

        //Conversion Explicita
        Kilo kilo1 = (Kilo)libra;
        Libra libra1 = (Libra)kilo;

        //Sobrecarga operadores de igualdad
        Kilo kilo11 = new Kilo(10);
        Libra libra11 = new Libra(20);

        Console.WriteLine(kilo==kilo11);
        Console.WriteLine(libra==libra11);

        //Sobrecargas + -
        Console.WriteLine(kilo+kilo1);
        Console.WriteLine(libra11+libra1);

        Console.WriteLine(kilo==libra);










        Console.ReadLine();

    }
}