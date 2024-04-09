using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть емейл для перевірки:");
        string email = Console.ReadLine();

        if (IsValidEmail(email))
        {
            Console.WriteLine("Вірний формат :)");
        }
        else
        {
            Console.WriteLine("Не вірний формат ;(");
        }
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        return Regex.IsMatch(email, pattern);
    }
}
