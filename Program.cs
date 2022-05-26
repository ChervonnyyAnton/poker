using System;

namespace PokerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "Poker";
            DealCards Dealer = new DealCards();
            bool Quit = false;

            while (!Quit)
            {
                Dealer = new DealCards();
                Dealer.Deal();
                char Continue = ' ';
                while(!(Continue.Equals('Y') || Continue.Equals('y')) && !(Continue.Equals('N') || Continue.Equals('n')))
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\nPlay again? (Y-N)");
                    Continue = Convert.ToChar(Console.ReadLine());
                    
                        if (Continue.Equals('Y') || Continue.Equals('y'))
                        {
                            Quit = false;
                        }
                        else if (Continue.Equals('N') || Continue.Equals('n'))
                        {
                            Quit = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Answer! Try (Y)es or (N)o!");
                        }
                    }
                }
            }
        }
    }
