using System.Numerics;

string Mese;

int Giorni;

Console.WriteLine("Inserisci il mese: ");
Mese=Console.ReadLine();

if (Mese == "Gennaio" || Mese ==  "Marzo" || Mese == "Maggio" || Mese == "Luglio" || Mese == "Agosto" || Mese == "Ottobre" || Mese == "Dicembre")
    {
    Giorni = 31;
    Console.Write("Questo mese ha ");
    Console.Write(Giorni);
    Console.Write(" Giorni");
}
else
{
    if (Mese == "Aprile" || Mese == "Giugno")
}