using System;
using System.Globalization;

class CompteCorrent
{
    public string NomClient { get; private set; }
    private decimal saldo;

    public CompteCorrent(string nomClient, decimal saldoInicial)
    {
        NomClient = nomClient;
        saldo = saldoInicial;
    }
    public void Ingressar(decimal quantitat)
    {
        if (quantitat > 0)
        {
            saldo += quantitat;
            Console.WriteLine($"{NomClient} ha ingressat {quantitat}€. Saldo actual: {saldo}€");
        }
        else
        {
            Console.WriteLine("La quantitat d'ingrés ha de ser positiva.");
        }
    }
    public void Retirar(decimal quantitat)
    {
        if (quantitat <= 0)
        {
            Console.WriteLine("La quantitat a retirar ha de ser positiva.");
            return;
        }
        decimal comissio = quantitat * 0.01m;
        decimal quantitatTotal = quantitat + comissio;
        if (quantitatTotal > saldo)
        {
            Console.WriteLine($"{NomClient} no té prou saldo per retirar {quantitat}€. Saldo actual: {saldo}€");
        }
        else
        {
            saldo -= quantitatTotal;
            Console.WriteLine($"{NomClient} ha retirat {quantitat}€ (comissió: {comissio}€). Saldo actual: {saldo}€");
        }
    }
    public decimal ConsultarSaldo()
    {
        return saldo;
    }
}


