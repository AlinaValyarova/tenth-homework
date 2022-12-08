using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Homework
{
    class BigRides : IGames
    {

        public void Beach()
        {
            Console.WriteLine("Beach started");
        }

        public void MouseTrap()
        {
            Console.WriteLine("Mousetrap started");
        }
        public void FishingSeason()
        {
            Console.WriteLine("Mousetrap started");
        }
        public void Postmans()
        {
            Console.WriteLine("Mousetrap started");
        }
        public void Sea()
        {
            Console.WriteLine("Mousetrap started");
        }
        public void Slides()
        {
            Console.WriteLine("Mousetrap started");
        }


        static void Game(List<Countries> list)
        {
            Countries country = new Countries();
            List<string> countries = new List<string>() { "Russia", "France", "China", "Ukraine" };
            List<string> players = new List<string>();
            List<string> losers = new List<string>();
            List<string> winners = new List<string>();
            var rnd = new Random();
            while (countries.Count != 0)
            {
                int a = rnd.Next(0, countries.Count);
                players.Add(countries[a]);
                countries.RemoveAt(a);
                int b = rnd.Next(0, countries.Count);
                players.Add(countries[b]);
                countries.RemoveAt(b);
                Console.WriteLine("{0} vs {1}", players[0], players[1]);
                int c = rnd.Next(0, players.Count);
                Console.WriteLine("Match is live...");
                Thread.Sleep(5000);
                Console.WriteLine("The winner is {0}", players[c]);
                winners.Add(players[c]);
                players.RemoveAt(c);
                losers.Add(players[0]);
                players.Clear();
            }
            Thread.Sleep(5000);
            Console.WriteLine("Match for the third place");
            Console.WriteLine("{0} vs {1}", losers[0], losers[1]);
            int wl = rnd.Next(0, losers.Count);
            Console.WriteLine("Match started");
            Thread.Sleep(5000);
            Console.WriteLine("Third place goes to: {0}", losers[wl]);
            foreach (var i in list)
            {
                if (i.name.Equals(losers[wl]))
                {
                    i.points += 2;
                }
                else
                {
                    i.points += 1;
                }
            }
            Thread.Sleep(5000);
            Console.WriteLine("Match for the first place");
            Console.WriteLine("{0} vs {1}", winners[0], winners[1]);
            int lw = rnd.Next(0, winners.Count);
            Console.WriteLine("Match started...");
            Thread.Sleep(5000);
            Console.WriteLine("First place goes to: {0}", winners[lw]);
            foreach (var i in list)
            {
                if (i.name.Equals(winners[lw]))
                {
                    i.points += 3;
                }
                else
                {
                    i.points += 5;
                }
            }

        }
        static void Main(string[] args)
        {
            List<Countries> countries = new List<Countries>();
            List<string> games = new List<string> { "Beach", "Mousetrap", "Sea","Fishing season","Postmans", "Slides"};
            Countries country1 = new Countries();
            Countries country2 = new Countries();
            Countries country3 = new Countries();
            Countries country4 = new Countries();
            country1.name = "Russia";
            country1.points = 0;
            countries.Add(country1);
            country2.name = "France";
            country2.points = 0;
            countries.Add(country2);
            country3.name = "China";
            country3.points = 0;
            countries.Add(country3);
            country4.name = "Ukraine";
            country4.points = 0;
            countries.Add(country4);
            byte num;
            do
            {
                
                Console.WriteLine("Choose needed option");
                Console.WriteLine("1 - start big rides");
                Console.WriteLine("2 - add a new game");
                Console.WriteLine("3 - exit");
                while (!Byte.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Wrong enter. Please try again");
                }
                switch (num)
                {
                    case 1:
                        int i = 0;
                        while (games.Count != 0)
                        {
                            Console.Clear();
                            var ran = new Random();
                            int b = ran.Next(0, games.Count);
                            Console.WriteLine("{0} started...", games[b]);
                            games.RemoveAt(b);
                            Thread.Sleep(5000);
                            Game(countries);
                            Thread.Sleep(5000);
                            Console.Clear();
                            i += 1;
                            Console.WriteLine("Leader board after {0} game", i);
                            countries.OrderBy(x => x.points);
                            foreach (var t in countries)
                            {
                                Console.WriteLine(t.name + " Points: " + t.points);
                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadKey();
                        }
                        Console.WriteLine("Thank you for whatching!");
                        continue;

                    case 2:
                        Console.WriteLine("Please, enter the password");
                        string pas = Console.ReadLine();
                        if (pas.ToLower().Equals("password"))
                        {
                            Console.WriteLine("Enter name of the game that you want to add");
                            string name = Console.ReadLine();
                            games.Add(name);
                            Console.WriteLine("Added successfully");
                        }
                        continue;
                        
                }


            }

            while (num != 3);
    }
    }
}
