namespace PokerGame
{
    class Results
    {
        public int GetScore(Card[] hand)
        {
            Evaluator evaluator = new Evaluator();
            evaluator.ValuesCounter(hand);
            evaluator.SuitesCounter(hand);

            if (evaluator.IsRoyalFlush())
            {
                return 120;
            }
            else if (evaluator.IsStraightFlush())
            {
                return 110;
            }
            else if (evaluator.IsCare())
            {
                return 100;
            }
            else if (evaluator.IsFullHouse())
            {
                return 90;
            }
            else if (evaluator.IsFlush())
            {
                return 80;
            }
            else if (evaluator.IsStraight())
            {
                return 70;
            }
            else if (evaluator.IsSet())
            {
                return 60;
            }
            else if (evaluator.IsTwoPair() && !evaluator.IsPair())
            {
                return 50;
            }
            else if (evaluator.IsPair() && !evaluator.IsTwoPair())
            {
                return 40;
            }
            else
            {
                return 35;
            }
        }

        public string PrintCombination(int score)
        {
            switch (score)
            {
                case 120:
                    return "ROYAL FLUSH";

                case 110:
                    return "STRAIGHT FLUSH";

                case 100:
                    return "FOUR OF A KIND";

                case 90:
                    return "FULL HOUSE";

                case 80:
                    return "FLUSH";

                case 70:
                    return "STRAIGHT";

                case 60:
                    return "THREE OF A KIND";

                case 50:
                    return "TWO PAIR";

                case 40:
                    return "PAIR";

                case 35:
                    return "HIGH CARD";

                default:
                    return "NONE";
            }
        }

        public string Announcement(int player, int computer)
        {
            if(player > computer)
            {
                return "PLAYER WON!";
            }
            else if (player == computer)
            {
                return "DRAW";
            }
            else
            {
                return "COMPUTER WON";
            }
        }

    }
}
