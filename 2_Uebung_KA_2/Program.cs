//Aufgabe 1 


/*
string sHöhe = "Höhe", sBreite = "Breite"; float fHöhe = 32.346F, fBreite = 15.193F;


Console.WriteLine("{0,10}{1,10}\n", sHöhe,sBreite);

Console.WriteLine($"{fHöhe,10:F1}{fBreite,10:F1}");

*/

//Aufgabe 5

Console.Write("Bitte geben Sie Ihren Umsatz ein: ");
double Umsatz= double.Parse(Console.ReadLine());

if (Umsatz < 100)

{
    Console.WriteLine("\nSie bekommen leider keinen Rabatt.");

}

else if (Umsatz >=100 && Umsatz<=500)
    {

    Console.WriteLine("\nSie bekommen einen Rabatt von 5%.");
    double N1Umsatz =(Umsatz * 95)/100;
    Console.WriteLine();
    Console.WriteLine(N1Umsatz + " ist ihr neuer Betrag");

}

else if (Umsatz >=500)
{
    Console.WriteLine("\nSie bekommen einen Rabatt von 10%");

}




