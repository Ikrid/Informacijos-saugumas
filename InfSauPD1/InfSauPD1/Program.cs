using System;

public class Sifravimas
{
    public static string SifruotiCezario(string tekstas, int raktas)
    {
        const string abeceles = "abcdefghijklmnopqrstuvwxyz0123456789";
        string uzkoduotasTekstas = "";

        foreach (char simbolis in tekstas)
        {
            int pozicija = abeceles.IndexOf(simbolis);
            if (pozicija != -1)
            {
                int naujaPozicija = (pozicija + raktas) % abeceles.Length;
                uzkoduotasTekstas += abeceles[naujaPozicija];
            }
            else
            {
                uzkoduotasTekstas += simbolis;
            }
        }

        return uzkoduotasTekstas;
    }

    public static string DesifruotiCezario(string uzkoduotasTekstas, int raktas)
    {
        const string abeceles = "abcdefghijklmnopqrstuvwxyz0123456789";
        string tekstas = "";

        foreach (char simbolis in uzkoduotasTekstas)
        {
            int pozicija = abeceles.IndexOf(simbolis);
            if (pozicija != -1)
            {
                int naujaPozicija = (pozicija - raktas + abeceles.Length) % abeceles.Length;
                tekstas += abeceles[naujaPozicija];
            }
            else
            {
                tekstas += simbolis;
            }
        }

        return tekstas;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Pasirinkite veiksmą:");
        Console.WriteLine("1 - Šifruoti");
        Console.WriteLine("2 - Dešifruoti");
        int veiksmas = int.Parse(Console.ReadLine());

        Console.WriteLine("Įveskite tekstą: ");
        string tekstas = Console.ReadLine();

        Console.WriteLine("Įveskite raktą (poslinkį): ");
        int raktas = int.Parse(Console.ReadLine());

        switch (veiksmas)
        {
            case 1:
                string uzkoduotasCezario = SifruotiCezario(tekstas, raktas);
                Console.WriteLine("Užkoduotas tekstas (Cezario): " + uzkoduotasCezario);
                break;
            case 2:
                string desifruotasCezario = DesifruotiCezario(tekstas, raktas);
                Console.WriteLine("Dešifruotas tekstas (Cezario): " + desifruotasCezario);
                break;
            default:
                Console.WriteLine("Nežinomas veiksmas.");
                break;
        }
    }
}