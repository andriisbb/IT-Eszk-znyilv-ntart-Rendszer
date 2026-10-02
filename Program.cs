using IT_Eszköznyilvántartó_Rendszer;
using System.IO;

List<Eszkoz> adatok = new List<Eszkoz>();

foreach(string sor in File.ReadAllLines("eszkozok.txt"))
{
    string[] mezok = sor.Split(';');
    if (!int.TryParse(mezok[3], out int raktardb))
    {
        raktardb = 0;
    }
    if (!int.TryParse(mezok[2], out int ar))
    {
        Console.WriteLine($"[HIBA] A(z) {mezok[0]} cikkszámú sor adata hibás, átugorva!");
        continue;
    }
    Eszkoz ujEszkoz = new Eszkoz(mezok[0], mezok[1], ar, raktardb);
    adatok.Add(ujEszkoz);
}
Console.WriteLine("\n===SIKERESEN BEOLVASOTT ESZKÖZÖK===");
foreach (Eszkoz eszkoz in adatok)
{
    Console.WriteLine(eszkoz);
}
Console.WriteLine($"\nRendszerben regisztrált eszközök száma: {Eszkoz.OsszesLetezoEszkoz} db");

double osszesBruttoAr = 0;
foreach(Eszkoz eszkoz in adatok)
{
    osszesBruttoAr += Penzugy.BruttoArSzamitas((double)eszkoz.BeszerzesiAr + eszkoz.RaktarKeszlet);
}
Console.WriteLine($"\nRaktárkészlet teljes bruttó értéke: {osszesBruttoAr:0,0} Ft");

Eszkoz legdragabb = adatok.MaxBy(e => e.BeszerzesiAr);
Console.WriteLine($"\nLegdrágább eszköz: {legdragabb.Nev} ({legdragabb.BeszerzesiAr} Ft)");