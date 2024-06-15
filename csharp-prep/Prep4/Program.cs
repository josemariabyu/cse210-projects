using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Solicitar números al usuario
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);
        
        // Calcular la suma
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        
        // Calcular el promedio
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");
        
        // Encontrar el número máximo
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
        
        // Encontrar el número positivo más pequeño
        int minPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {minPositive}");
        
        // Ordenar la lista
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}