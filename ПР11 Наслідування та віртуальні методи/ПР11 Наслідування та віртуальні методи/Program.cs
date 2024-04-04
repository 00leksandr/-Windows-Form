using System;
using System.Collections.Generic;

abstract class UtilitiesPrice
{
    protected string name;
    public abstract double Price();
}

class FixedPrice : UtilitiesPrice
{
    private double fixedAmount;
    public FixedPrice(string name, double fixedAmount)
    {
        this.name = name;
        this.fixedAmount = fixedAmount;
    }
    public override double Price()
    {
        return fixedAmount;
    }
}

class ConsumedAmountPrice : UtilitiesPrice
{
    private double rate;
    private double consumedAmount;
    public ConsumedAmountPrice(string name, double rate, double consumedAmount)
    {
        this.name = name;
        this.rate = rate;
        this.consumedAmount = consumedAmount;
    }
    public override double Price()
    {
        return rate * consumedAmount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<UtilitiesPrice> utilities = new List<UtilitiesPrice>();

        while (true)
        {
            Console.WriteLine("Виберіть тип платежу (1 - фіксована ціна, 2 - оплата за спожитий ресурс, 0 - вихід):");
            string choice = Console.ReadLine();

            if (choice == "0")
                break;

            Console.Write("Введіть назву платежу: ");
            string name = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Введіть фіксовану суму: ");
                double fixedAmount = double.Parse(Console.ReadLine());
                utilities.Add(new FixedPrice(name, fixedAmount));
            }
            else if (choice == "2")
            {
                Console.Write("Введіть ставку: ");
                double rate = double.Parse(Console.ReadLine());
                Console.Write("Введіть спожиту кількість: ");
                double consumedAmount = double.Parse(Console.ReadLine());
                utilities.Add(new ConsumedAmountPrice(name, rate, consumedAmount));
            }
        }

        double totalPrice = 0;
        foreach (UtilitiesPrice utility in utilities)
        {
            totalPrice += utility.Price();
        }

        Console.WriteLine("Загальна сума: " + totalPrice);
        Console.ReadLine();
    }
}