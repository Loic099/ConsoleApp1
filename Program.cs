using System;

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);


double rayon = 2.5;
double aire = Math.PI * rayon * rayon;

Console.WriteLine(aire);

Fonction();

void Fonction()
{
    int a = 5;
    int b = 5;
    if (a + b > 10)
        Console.WriteLine("The answer is greater than 10");
    else
        Console.WriteLine("The answer is not greater than 10");

}
