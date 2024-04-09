using System;
using System.Collections.Generic;
using System.Linq;

class Inventory
{
    private List<Item> items;

    public Inventory()
    {
        items = new List<Item>();
    }

    public void AddItem(string name, string type, double weight)
    {
        items.Add(new Item(name, type, weight));
    }

    public void RemoveItem(string name)
    {
        var itemToRemove = items.FirstOrDefault(item => item.Name == name);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
        }
    }

    public string MostCommonType()
    {
        if (items.Count == 0)
        {
            return "Інвентар пустий";
        }

        var typesCount = items.GroupBy(item => item.Type)
                              .Select(group => new { Type = group.Key, Count = group.Count() })
                              .OrderByDescending(x => x.Count);

        return typesCount.First().Type;
    }

    public string LeastCommonType()
    {
        if (items.Count == 0)
        {
            return "Інвентар пустий";
        }

        var typesCount = items.GroupBy(item => item.Type)
                              .Select(group => new { Type = group.Key, Count = group.Count() })
                              .OrderBy(x => x.Count);

        return typesCount.First().Type;
    }
}

class Item
{
    public string Name { get; }
    public string Type { get; }
    public double Weight { get; }

    public Item(string name, string type, double weight)
    {
        Name = name;
        Type = type;
        Weight = weight;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        while (true)
        {
            Console.WriteLine("Введіть назву предмету (або 'end' для завершення):");
            string name = Console.ReadLine();

            if (name.ToLower() == "end")
                break;

            Console.WriteLine("Введіть тип предмету:");
            string type = Console.ReadLine();

            Console.WriteLine("Введіть вагу предмету:");
            double weight;
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Невірний формат. Введіть число для ваги:");
            }

            inventory.AddItem(name, type, weight);
        }

        if (inventory.MostCommonType() != "Інвентар пустий")
        {
            Console.WriteLine("Найпоширеніший тип : " + inventory.MostCommonType());
            Console.WriteLine("Найменш поширеніший тип : " + inventory.LeastCommonType());

            Console.WriteLine("Введіть назву предмету, який потрібно видалити:");
            string itemToRemove = Console.ReadLine();
            inventory.RemoveItem(itemToRemove);

            Console.WriteLine("Найпоширеніший тип після видалення : " + inventory.MostCommonType());
            Console.WriteLine("Найменш поширений тип після видалення : " + inventory.LeastCommonType());
        }
        else
        {
            Console.WriteLine("Інвентар порожній.");
        }
    }
}