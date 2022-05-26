using System;
using System.Linq;

namespace PokerGame
{
    class DealCards : DeckOfCards
    {
        private Card[] PlayerHand;
        private Card[] ComputerHand;
        private Card[] SortedPlayerHand;
        private Card[] SortedComputerHand;
        private string Announcement;
        private string PlayerCombo;
        private string ComputerCombo;

        public DealCards()
        {
            PlayerHand = new Card[5];
            SortedPlayerHand = new Card[5];
            ComputerHand = new Card[5];
            SortedComputerHand = new Card[5];
        }

        public string GetPlayerCombo()
        {
            return PlayerCombo;
        }

        public string GetComputerCombo()
        {
            return ComputerCombo;
        }

        public string GetAnnouncement()
        {
            return Announcement;
        }

        public void Deal()
        {
            SetUpDeck();
            GetHand();
            SortCards();
            DisplayCards();
            EvaluateHands();
        }

        public void GetHand()
        {
            for (int i = 0; i < 5; i++)
            {
                PlayerHand[i] = GetDeck[i];
            }

            for (int i = 5; i < 10; i++)
            {
                ComputerHand[i - 5] = GetDeck[i];
            }
        }

        public void SortCards()
        {
            var QueryPlayer = from hand in PlayerHand
                              orderby hand.MyValue
                              select hand;

            var QueryComputer = from hand in ComputerHand
                              orderby hand.MyValue
                              select hand;

            var index = 0;

            foreach (Card element in QueryPlayer.ToList())
            {
                SortedPlayerHand[index] = element;
                index++;
            }

            index = 0;

            foreach (Card element in QueryComputer.ToList())
            {
                SortedComputerHand[index] = element;
                index++;
            }
        }

        public void DisplayCards()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("PLAYER'S HAND");

            for (int i = 0; i < 5; i++)
            {
                DrowCards.DrawCardSuitValue(SortedPlayerHand[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("COMPUTER'S HAND");
            for (int i = 5; i < 10; i++)
            {
                //DrowCards.DrawCardOutline(x, y);
                DrowCards.DrawCardSuitValue(SortedComputerHand[i - 5]);
            }
            Console.WriteLine("");
            Console.WriteLine("");

        }

        public void EvaluateHands()
        {
            Draw draw = new Draw();
            Results computerResults = new Results();
            Results playerResults = new Results();
            int playerScore = playerResults.GetScore(SortedPlayerHand);
            int computerScore = computerResults.GetScore(SortedComputerHand);
            PlayerCombo = playerResults.PrintCombination(playerScore);
            ComputerCombo = computerResults.PrintCombination(computerScore);
            string results = playerResults.Announcement(playerScore, computerScore);
            if(results != "DRAW")
            {
                Announcement = results;
            }
            else
            {
                Announcement = draw.DecideDraw(PlayerCombo, SortedPlayerHand, SortedComputerHand);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Player has {GetPlayerCombo()}");
            Console.WriteLine($"Computer has {GetComputerCombo()}");
            Console.WriteLine(Announcement);
        }
    }
}
