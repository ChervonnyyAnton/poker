using System;

namespace PokerGame
{
     class DeckOfCards : Card
    {
        const int NUM_OF_CARDS = 52;
        private Card[] Deck;

        public DeckOfCards()
        {
            Deck = new Card[NUM_OF_CARDS];
        }

        public Card[] GetDeck { get { return Deck; } }

        public void SetUpDeck()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    Deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }

        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;
            for (int shuffleTimes = 0; shuffleTimes < 51; shuffleTimes++)
            {
                for (int i = 0; i < NUM_OF_CARDS; i++)
                {
                    int secondCardIndex = rand.Next(13);
                    temp = Deck[i];
                    Deck[i] = Deck[secondCardIndex];
                    Deck[secondCardIndex] = temp;
                }
            }
        }
    }
}