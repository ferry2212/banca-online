using System;
using System.Globalization; //això es perquè surti el símbol d'euro

using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        CultureInfo.CurrentCulture = new CultureInfo("ca-ES"); //això també es perquè surti el símbol d'euro
        Banquer banquer = new Banquer();
        banquer.CrearCompte("Messi", 1000);
        banquer.CrearCompte("Lamine", 500);
        banquer.IngressarDiners("Messi", 200);
        banquer.RetirarDiners("Messi", 100);
        banquer.ConsultarSaldo("Messi");
        banquer.RetirarDiners("Lamine", 600);
        banquer.RetirarDiners("Lamine", 300);
        banquer.ConsultarSaldo("Lamine");
    }
}
