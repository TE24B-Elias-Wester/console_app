int i = 0;
int a = 0;
int b = 0;
string name = "";
string ConsoleName = "";
string TerminalColor = "";

Console.WriteLine("Hej, Vad heter du?");

while (a < 1)
{
    name = Console.ReadLine();
    if (name == "")
    {
        Console.WriteLine("Du skrev inget, skriv igen.");
    }
    else
    {
        a++;
    }
}

Console.WriteLine($"Hej! {name}");
Console.WriteLine("Döp namnet på den här instansen");


while (b < 1)
{
    ConsoleName = Console.ReadLine();
    if (ConsoleName == "")
    {
        Console.WriteLine("Du skrev inget, skriv igen.");
    }
    else
    {
        b++;
    }
}

Console.Title = ConsoleName;
Console.WriteLine($"Där!, du döpte terminalen till {ConsoleName}, vill du ändra färgen också?"); 
Console.WriteLine("Jag kan ändra till \x1b[31mRED \x1b[32mGREEN\x1b[0m eller \x1b[34mBLUE\x1b[0m, RGB!!");

while (i < 1)
{
    TerminalColor = Console.ReadLine();
    if (TerminalColor == "RED")
    {
        Console.BackgroundColor = ConsoleColor.Red;
        i++;
        Console.Clear();
        Console.WriteLine("Nu är terminalen Röd!");
    }
    else if (TerminalColor == "GREEN")
    {
        Console.BackgroundColor = ConsoleColor.Green;
        i++;
        Console.Clear();
        Console.WriteLine("Nu är terminalen Grön!");
    }
    else if (TerminalColor == "BLUE")
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        i++;
        Console.Clear();
        Console.WriteLine("Nu är terminalen Blå!");
    }
    else
    {
        Console.WriteLine("Du skrev inte in en färg som jag vet eller använde fel formatering, vänligen försök igen");
    }
}

Console.ReadLine();

// Console.WriteLine("Hej, Skriv 3 siffror");
// Console.WriteLine("Ord 1");
// string WordOne = Console.ReadLine();
// Console.WriteLine("Ord 2");
// string WordTwo = Console.ReadLine();
// Console.WriteLine("Ord 3");
// string WordThree = Console.ReadLine();
// Console.WriteLine($"Du är {WordOne} år gammal, kommer gifta dig om {WordTwo} år och kommer ha en networth på {WordThree} kronor");
// Console.ReadLine();