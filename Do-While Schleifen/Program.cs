//Do-While Aufgabe
/*
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


*/



Console.WriteLine("Bitte wählen Sie eine Tagesziffer: \n");
Console.WriteLine("---Ihre verfügbaren Ziffern---\n");
Console.WriteLine( 
    "\nZiffer: 1\n" +
    "\nZiffer: 2\n" +
    "\nZiffer: 3\n" +
    "\nZiffer: 4\n" +
    "\nZiffer: 5\n" +
    "\nZiffer: 6\n" +
    "\nZiffer: 7\n");

string TZ =Console.ReadLine();

switch (TZ)
{ 
    case "1":
        Console.WriteLine("\nWir haben Montag!");
        break;

    case "2":
        Console.WriteLine("\nWir haben Dienstag!");
        break;

    case "3":
        Console.WriteLine("\nWir haben Mittwoch!");
        break;

    case "4":
        Console.WriteLine("\nWir haben Donnerstag!");
        break;

    case "5":
        Console.WriteLine("\nWir haben Freitag!");
        break;

    case "6":
        Console.WriteLine("\nWir haben Samstag!");
        break;

    case "7":
        Console.WriteLine("\nWir haben Sonntag!");
        break;

    case "":
        Console.WriteLine("\nFalsche Eingabe!");
        break;

}