using System;
using System.Collections.Generic;

class Program
{
    // Клас для зберігання гравця та його балів
    class Player
    {
        public string Name { get; set; }
        public List<int> Points { get; set; }

        public Player(string name, List<int> points)
        {
            Name = name;
            Points = points;
        }

        // Метод для отримання суми балів гравця
        public int GetTotalPoints()
        {
            int total = 0;
            foreach (int point in Points)
            {
                total += point;
            }
            return total;
        }
    }

    // Метод для визначення топ-3 гравців за сумою балів
    static List<Player> GetTopThreePlayers(List<Player> players)
    {
        players.Sort((p1, p2) => p2.GetTotalPoints().CompareTo(p1.GetTotalPoints()));
        return players.GetRange(0, Math.Min(3, players.Count));
    }

    static void Main(string[] args)
    {
        List<Player> players = new List<Player>();

        // Зчитування даних про гравців та їх бали
        while (true)
        {
            Console.Write("Введіть ім'я гравця (або 'end' для завершення вводу): ");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "end")
                break;

            Console.Write("Введіть бали за 3 останні гри (через пробіл): ");
            string[] pointsStr = Console.ReadLine().Split();
            List<int> points = new List<int>();
            foreach (string pointStr in pointsStr)
            {
                if (int.TryParse(pointStr, out int point))
                {
                    points.Add(point);
                }
                else
                {
                    Console.WriteLine("Неправильний формат балів. Бали мають бути цілими числами.");
                    break;
                }
            }
            players.Add(new Player(playerName, points));
        }

        // Визначення та виведення топ-3 гравців
        List<Player> topPlayers = GetTopThreePlayers(players);
        Console.WriteLine("Топ-3 гравці за сумою балів:");
        for (int i = 0; i < topPlayers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {topPlayers[i].Name} - {topPlayers[i].GetTotalPoints()} балів");
        }
    }
}
