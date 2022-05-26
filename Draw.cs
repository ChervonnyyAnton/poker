namespace PokerGame
{
    class Draw : Results
    {
        public int CountAllValues(Card[] hand)
        {
            int sum = 0;
            foreach (Card c in hand)
            {
                sum += (int)c.MyValue;
            }

            return sum;
        }

        public int CountCare(Card[] hand)
        {
            if (hand[4].MyValue == hand[3].MyValue && hand[3].MyValue == hand[2].MyValue && hand[2].MyValue == hand[1].MyValue)
            {
                return (int)hand[4].MyValue + (int)hand[3].MyValue + (int)hand[2].MyValue + (int)hand[1].MyValue;
            }
            else
            {
                return (int)hand[3].MyValue + (int)hand[2].MyValue + (int)hand[1].MyValue + (int)hand[0].MyValue;
            }
        }

        public int CountSet(Card[] hand)
        {
            if(hand[4].MyValue == hand[3].MyValue && hand[3].MyValue == hand[2].MyValue)
            {
                return (int)hand[4].MyValue + (int)hand[3].MyValue + (int)hand[2].MyValue;
            }
            else
            {
                return (int)hand[0].MyValue + (int)hand[1].MyValue + (int)hand[2].MyValue;
            }
            
        }

        public int CountPair(Card[] hand)
        {
            if (hand[4].MyValue == hand[3].MyValue)
            {
                return (int)hand[4].MyValue + (int)hand[3].MyValue;
            }
            else if (hand[3].MyValue == hand[2].MyValue)
            {
                return (int)hand[3].MyValue + (int)hand[2].MyValue;
            }
            else if (hand[2].MyValue == hand[1].MyValue)
            {
                return (int)hand[2].MyValue + (int)hand[1].MyValue;
            }
            else
            {
                return (int)hand[1].MyValue + (int)hand[0].MyValue;
            }
        }

        public int CountTwoPair(Card[] hand)
        {
            if(hand[4].MyValue == hand[3].MyValue && hand[2].MyValue == hand[1].MyValue)
            {
                return (int)hand[4].MyValue + (int)hand[3].MyValue + (int)hand[2].MyValue + (int)hand[1].MyValue;
            }
            else if (hand[4].MyValue == hand[3].MyValue && hand[1].MyValue == hand[0].MyValue)
            {
                return (int)hand[4].MyValue + (int)hand[3].MyValue + (int)hand[1].MyValue + (int)hand[0].MyValue;
            }
            else
            {
                return (int)hand[0].MyValue + (int)hand[1].MyValue + (int)hand[2].MyValue + (int)hand[3].MyValue;
            }
        }

        public string DecideDraw(string combination, Card[] player, Card[] computer)
        {
            int playerScore = 0;
            int computerScore = 0;
            switch (combination)
            {
                case "ROYAL FLUSH":
                    return "Incredible!";

                case "STRAIGHT FLUSH":
                    playerScore = CountAllValues(player);
                    computerScore = CountAllValues(computer);
                    break;

                case "FOUR OF A KIND":
                    playerScore = CountCare(player);
                    computerScore = CountCare(computer);
                    break;

                case "FULL HOUSE":
                    playerScore = CountAllValues(player);
                    computerScore = CountAllValues(computer);
                    break;

                case "FLUSH":
                    playerScore = CountAllValues(player);
                    computerScore = CountAllValues(computer);
                    break;

                case "STRAIGHT":
                    playerScore = CountAllValues(player);
                    computerScore = CountAllValues(computer);
                    break;

                case "THREE OF A KIND":
                    playerScore = CountSet(player);
                    computerScore = CountSet(computer);
                    break;

                case "TWO PAIR":
                    playerScore = CountTwoPair(player);
                    computerScore = CountTwoPair(computer);
                    break;

                case "PAIR":
                    playerScore = CountPair(player);
                    computerScore = CountPair(computer);
                    break;

                case "HIGH CARD":
                    bool isFifthCardEqual = (int)player[4].MyValue == (int)computer[4].MyValue;
                    bool isFourthCardEqual = (int)player[3].MyValue == (int)computer[3].MyValue;
                    bool isThirdCardEqual = (int)player[2].MyValue == (int)computer[2].MyValue;
                    bool isSecondCardEqual = (int)player[1].MyValue == (int)computer[1].MyValue;
                    bool isFirstCardEqual = (int)player[0].MyValue == (int)computer[0].MyValue;

                    if (isFifthCardEqual && !isFourthCardEqual)
                    {
                        playerScore = (int)player[4].MyValue + (int)player[3].MyValue;
                        computerScore = (int)computer[4].MyValue + (int)computer[3].MyValue;
                    }
                    else if(isFourthCardEqual && isFifthCardEqual && !isThirdCardEqual)
                    {
                        playerScore = (int)player[4].MyValue + (int)player[3].MyValue + (int)player[2].MyValue;
                        computerScore = (int)computer[4].MyValue + (int)computer[3].MyValue + (int)computer[2].MyValue;
                    }
                    else if (isThirdCardEqual && isFourthCardEqual && isFifthCardEqual && !isSecondCardEqual)
                    {
                        playerScore = (int)player[4].MyValue + (int)player[3].MyValue + (int)player[2].MyValue + (int)player[1].MyValue;
                        computerScore = (int)computer[4].MyValue + (int)computer[3].MyValue + (int)computer[2].MyValue + (int)computer[1].MyValue;
                    }
                    else if (isSecondCardEqual && isThirdCardEqual && isFourthCardEqual && isFifthCardEqual && !isFirstCardEqual)
                    {
                        playerScore = (int)player[4].MyValue + (int)player[3].MyValue + (int)player[2].MyValue + (int)player[1].MyValue + (int)player[0].MyValue;
                        computerScore = (int)computer[4].MyValue + (int)computer[3].MyValue + (int)computer[2].MyValue + (int)computer[1].MyValue + (int)computer[0].MyValue;
                    }
                    else
                    {
                        playerScore = CountAllValues(player);
                        computerScore = CountAllValues(computer);
                    }
                    break;

                default:
                    playerScore = 0;
                    computerScore = 0;
                    break;
            }
            return Announcement(playerScore, computerScore);
        }
    }
}
