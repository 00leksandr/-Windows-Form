using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть свій вік: ");
        int age = int.Parse(Console.ReadLine());

        string[] listVaccins = { "Одноразова для дітей до 10 років", "Вакцина для підлітків", "Вакцина для повнолітніх", "Вакцина від деменції!!!" };

        if (age < 10)
        {
            Console.WriteLine(listVaccins[0]);
        }
        else if (age >= 10 && age < 18)
        {
            Console.WriteLine(listVaccins[1]);
        }
        else if (age >= 18 && age < 25)
        {
            Console.WriteLine(listVaccins[2]);
        }
        else
        {
            Console.WriteLine(listVaccins[3]);
        }
    }
}
