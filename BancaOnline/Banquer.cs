using System;
using System.Collections.Generic;

class Banquer
{
    private Dictionary<string, CompteCorrent> comptes = new Dictionary<string, CompteCorrent>();

    public void CrearCompte(string nomClient, decimal saldoInicial)
    {
        if (comptes.ContainsKey(nomClient))
        {
            Console.WriteLine($"El compte per {nomClient} ja existeix.");
        }
        else
        {
            CompteCorrent nouCompte = new CompteCorrent(nomClient, saldoInicial);
            comptes.Add(nomClient, nouCompte);
            Console.WriteLine($"S'ha creat el compte per {nomClient} amb un saldo inicial de {saldoInicial:C}.");
        }
    }

    public void IngressarDiners(string nomClient, decimal quantitat)
    {
        if (comptes.ContainsKey(nomClient))
        {
            comptes[nomClient].Ingressar(quantitat);
        }
        else
        {
            Console.WriteLine($"No s'ha trobat cap compte per {nomClient}.");
        }
    }

    public void RetirarDiners(string nomClient, decimal quantitat)
    {
        if (comptes.ContainsKey(nomClient))
        {
            comptes[nomClient].Retirar(quantitat);
        }
        else
        {
            Console.WriteLine($"No s'ha trobat cap compte per {nomClient}.");
        }
    }

    public void ConsultarSaldo(string nomClient)
    {
        if (comptes.ContainsKey(nomClient))
        {
            Console.WriteLine($"Saldo de {nomClient}: {comptes[nomClient].ConsultarSaldo():C}");
        }
        else
        {
            Console.WriteLine($"No s'ha trobat cap compte per {nomClient}.");
        }
    }
}
