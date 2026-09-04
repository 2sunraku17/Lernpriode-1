Console.WriteLine("===== True or False Quiz=====");
int punkte = 0;
int maxpunkte = 3;
Console.WriteLine("Sind sie ein Mensch true/false? ");
bool antwort1 = Convert.ToBoolean(Console.ReadLine());
if (antwort1 == true)
{
    Console.WriteLine("Das ist Richtig!!");
    punkte++;
}
else
{
    Console.WriteLine("Das ist Falsch!!");
}

Console.WriteLine("Sind sie ein Tier true/false? ");
bool antwort2 = Convert.ToBoolean(Console.ReadLine());
if (antwort2 == false)
{
    Console.WriteLine("Das ist Richtig!!");
    punkte++;
}
else
{
    Console.WriteLine("Das ist Falsch!!");
}
Console.WriteLine("Sind sie ein Roboter true/false? ");
bool antwort3 = Convert.ToBoolean(Console.ReadLine());
if (antwort3 == false)
{
    Console.WriteLine("Das ist Richtig!!");
    punkte++;

}
else
{
    Console.WriteLine("Das ist Falsch!!");

}
Console.WriteLine("BONUS FRAGE!!!");
Console.WriteLine("Welcher ist der 2 Planet in unserem Sonnensystem?");
string antwort4 = Convert.ToString(Console.ReadLine());
if (antwort4.ToLower() == "venus")
{
    Console.WriteLine("Das ist richtig!!");
    Console.WriteLine("Sie bekommen einen Bonuspunkt!");
    punkte++;
}
else
{
    Console.WriteLine("Das ist falsch!!");
    Console.Write("Sie bekommen den Bonuspunkt leider nicht...");
}
    Console.WriteLine("Ihre Punktzahl ist " + punkte + "/3");
double Note = ((double)punkte / maxpunkte * 5 + 1);

if (punkte > maxpunkte)
{
    Console.Write("WOWWW SIE HABEN DIE MAXPUNKTZAHL ÜBERTROFFEN, IHRE NOTE IST EINE 6+");

}
else
{
    Console.Write("Ihre Note ist " + Note);
}
Console.Read();



