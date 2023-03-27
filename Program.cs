using CA230327;
using System.Text;

List<Donto> dontok = new List<Donto>();
StreamReader sr = new StreamReader(
    "..\\..\\..\\res\\SuperBowl.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    dontok.Add(new Donto(sr.ReadLine()));
}

Console.WriteLine($"4. feladat: döntők száma: {dontok.Count}");

int osszkulonbeg = 0;
foreach  (var d in dontok)
{
    osszkulonbeg += (d.GyoztesPont - d.VesztesPont);
}
float atlKul = osszkulonbeg / (float)dontok.Count;
Console.WriteLine($"5. feladat: átlagos pontkülönbség: {atlKul:0.0}");

int maxi = 0;
for (int i = 1; i < dontok.Count; i++)
{
    if (dontok[i].Nezoszam > dontok[maxi].Nezoszam)
    {
        maxi = i;
    }
}
Console.WriteLine("legmagasabb nézőszám a döntők során:\n" +
    $"\tSorszám (dátum): {dontok[maxi].Ssz.ArabSsz} ({dontok[maxi].Datum.ToShortDateString()})\n" +
    $"\tGyőztes csapat: {dontok[maxi].Gyoztes}, szerzett pontok: {dontok[maxi].GyoztesPont}\n" +
    $"\tVesztes csapat: {dontok[maxi].Vesztes}, szerzett pontok: {dontok[maxi].VesztesPont}\n" +
    $"\tHelyszín: {dontok[maxi].Helyszin}\n" +
    $"\tVáros, Állam: {dontok[maxi].VarosAllam}\n" +
    $"\tNézőszám: {dontok[maxi].Nezoszam}");

