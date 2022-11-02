//Do-While Aufgabe

int Kontostand = 1000;

while (Kontostand >=0)

{
    Console.WriteLine("Ihr Kontostand beträgt: " + Kontostand + " EUR");

    Kontostand -= 100;

}




Console.WriteLine("Bitte geben Sie Ihren Namen ein: ");
string Name= Console.ReadLine();

 while (Name == "")

{

    Console.WriteLine("Sie haben eine Falsche Eingabe gemacht!\n");
    Console.WriteLine("Bitte geben Sie Ihren Namen erneut ein: ");
    Name = Console.ReadLine();

}



