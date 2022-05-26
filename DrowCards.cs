using System;

namespace PokerGame
{
    class DrowCards
    {
        public static void DrawCardSuitValue(Card card)
        {
            char cardSuit = ' ';

            switch (card.MySuit)
            {
                case Card.SUIT.HEARTS:
                    cardSuit = '♥';
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case Card.SUIT.DIAMONDS:
                    cardSuit = '♦';
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case Card.SUIT.CLUBS:
                    cardSuit = '♠';
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case Card.SUIT.SPADES:
                    cardSuit = '♣';
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            Console.Write($"\n{cardSuit} {card.MyValue}");
        }
    }
}
