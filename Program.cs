using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        Random rng;
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");


            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() != "yes")
            {
                Console.WriteLine("GoodBye!");
                return;
            }











            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");


            string seeList = Console.ReadLine();

            //seeList = bool.Parse(Console.ReadLine());
            if (seeList.ToLower() == "sure")
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");

                string addToList = Console.ReadLine();
                Console.WriteLine();
                while (addToList.ToLower() == "yes")
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");


                    string ATL = Console.ReadLine();



                    while (ATL.ToLower() == "yes")
                    {
                        Console.Write("Connecting to the database");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();
                        Console.Write("Choosing your random activity");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();
                        Random rng = new Random();
                        int randomNumber = rng.Next(activities.Count);
                        string randomActivity = activities[randomNumber];
                        if (userAge > 21 && randomActivity == "Wine Tasting")
                        {
                            randomNumber = rng.Next(activities.Count);
                            randomActivity = activities[randomNumber];
                            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                            activities.Remove(randomActivity);
                            Console.WriteLine("Pick something else!");



                        }
                        Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                        Console.WriteLine();
                        bool CT = bool.Parse(Console.ReadLine());

                    }
                }
            }
        }
    }
}
