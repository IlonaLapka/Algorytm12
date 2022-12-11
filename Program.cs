using System;
using System.Collections.Generic;

namespace Algorytm12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj resztę poniezej 10 zl: ");
            double x = Double.Parse(Console.ReadLine());
            List<Coin> Coins = new List<Coin>()
            {
                new Coin() { Value = 0.01, Amount = 5 },
                new Coin() { Value = 0.02, Amount = 15 },
                new Coin() { Value = 0.05, Amount = 2 },
                new Coin() { Value = 0.1, Amount = 2 },
                new Coin() { Value = 0.2, Amount = 0 },
                new Coin() { Value = 0.5, Amount = 1 },
                new Coin() { Value = 1, Amount = 6 },
                new Coin() { Value = 2, Amount = 1 },
                new Coin() { Value = 5, Amount = 0 }
            };
            int howManyAtAll = 0;
            int y = 0;
            int i = 8;
            try
            {
                while (x > 0)
                {
                    if (Coins[i].Amount > 0 && x >= Coins[i].Value)
                    {
                        x = Math.Round(x - Coins[i].Value, 2);
                        Coins[i].Amount--;
                        howManyAtAll++;
                        y++;

                    }
                    else
                    {
                        if (y > 0)
                        {
                            Console.WriteLine(Coins[i].Value >= 1 ? y + " x " + Coins[i].Value + "zł"
                            : y + " x " + Coins[i].Value * 100 + "gr");
                        }
                        i--;
                        y = 0;
                    }
                }
                if (y > 0)
                {
                    Console.WriteLine(Coins[i].Value >= 1 ? y + " x " + Coins[i].Value + "zł"
                    : y + " x " + Coins[i].Value * 100 + "gr");
                }

                Console.WriteLine("Wydano " + howManyAtAll + " monet.");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Niestety nie mam jak wydać :(");
            }
        }
    }
}
