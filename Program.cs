using IT_Eszköznyilvántartó_Rendszer;
using System.IO;

List<Eszkoz> eszkozok = new List<Eszkoz>();

string sorok = File.ReadAllLines(eszkozok.txt);

foreach(string sor in sorok)
{
    string[] adatok = sor.Split(';');
}