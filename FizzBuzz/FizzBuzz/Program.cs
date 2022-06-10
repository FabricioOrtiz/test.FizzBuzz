// See https://aka.ms/new-console-template for more information
/*
 Escribir un programa que muestre en pantalla los números del 1 al 100, sustituyendo los múltiplos de 3 por la palabra “fizz”, los múltiplos de 5 por “buzz” y los múltiplos de ambos, es decir, los múltiplos de 3 y 5 (o de 15), por la palabra “fizzbuzz”.
 */


Console.WriteLine("Hello, World!");
int i;
for (i = 1; i <= 15; i++)
{

    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine("fizzbuzz ");
  else if (i % 3 == 0)
        Console.WriteLine("fizz ");
  else if (i % 5 == 0)
        Console.WriteLine("buzz ");
  else
        Console.WriteLine(i + " ");
}