Console.WriteLine("Willkommen zum Zahlen Guesser!!");

Random random = new Random();
int geheimzahl = random.Next(1, 101);

Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 gewählt.");

int guess;

do
{
    Console.WriteLine("Rate die Zahl:");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess == geheimzahl)
    {
        Console.WriteLine("Richtig!");
    }
    else if (guess < geheimzahl)
    {
        Console.WriteLine("Höher!");
    }
    else
    {
        Console.WriteLine("Tiefer!");
    }

} while (guess != geheimzahl);

Console.WriteLine("Du hast die Zahl erraten!");
