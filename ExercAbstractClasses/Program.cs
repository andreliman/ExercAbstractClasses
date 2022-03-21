using ExercAbstractClasses.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual ou company (i/c)?: ");
                char typeOfPayer = char.Parse(Console.ReadLine());

                if (typeOfPayer == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    list.Add(new Company(numberOfEmployees, name, anualIncome));
                }
            }

            double taxesSum = 0.0;

            Console.WriteLine("TAXES PAID:");
            foreach (Payer payer in list)
            {
                Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                taxesSum += payer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {taxesSum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
