namespace PokerGame
{
    class Evaluator : Card
    {

        int _ace;
        int _king;
        int _queen;
        int _jack;
        int _ten;
        int _nine;
        int _eight;
        int _seven;
        int _six;
        int _five;
        int _four;
        int _three;
        int _two;

        int _hearts = 0;
        int _spades = 0;
        int _diamonds = 0;
        int _clubs = 0;

        public bool IsFlush()
        {
            if (_hearts == 5 || _spades == 5 || _diamonds == 5 || _clubs == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStraight()
        {
            if (_two == 1 && _three == 1 && _four == 1 && _five == 1 && _six == 1)
            {
                return true;
            }
            else if (_three == 1 && _four == 1 && _five == 1 && _six == 1 && _seven == 1)
            {
                return true;
            }
            else if (_four == 1 && _five == 1 && _six == 1 && _seven == 1 && _eight == 1)
            {
                return true;
            }
            else if (_five == 1 && _six == 1 && _seven == 1 && _eight == 1 && _nine == 1)
            {
                return true;
            }
            else if (_six == 1 && _seven == 1 && _eight == 1 && _nine == 1 && _ten == 1)
            {
                return true;
            }
            else if (_seven == 1 && _eight == 1 && _nine == 1 && _ten == 1 && _jack == 1)
            {
                return true;
            }
            else if (_eight == 1 && _nine == 1 && _ten == 1 && _jack == 1 && _queen == 1)
            {
                return true;
            }
            else if (_nine == 1 && _ten == 1 && _jack == 1 && _queen == 1 && _king == 1)
            {
                return true;
            }
            else if (_ten == 1 && _jack == 1 && _queen == 1 && _king == 1 && _ace == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsRoyalFlush()
        {
            bool isRoyal = _ten == 1 && _jack == 1 && _queen == 1 && _king == 1 && _ace == 1;
            return isRoyal && IsFlush();
        }

        public bool IsStraightFlush()
        {
            return IsFlush() && IsStraight();
        }

        public bool IsCare()
        {
            if (HowManyMatches(4) == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSet()
        {
            if (HowManyMatches(3) == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsTwoPair()
        {
            if (HowManyMatches(2) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPair()
        {
            if (HowManyMatches(2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFullHouse()
        {
            if (IsPair() && IsSet())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCardValue(VALUE value)
        {
            switch (value)
            {
                case VALUE.TWO:
                    return 2;

                case VALUE.THREE:
                    return 3;

                case VALUE.FOUR:
                    return 4;

                case VALUE.FIVE:
                    return 5;

                case VALUE.SIX:
                    return 6;

                case VALUE.SEVEN:
                    return 7;

                case VALUE.EIGHT:
                    return 8;

                case VALUE.NINE:
                    return 9;

                case VALUE.TEN:
                    return 10;

                case VALUE.JACK:
                    return 15;

                case VALUE.QUEEN:
                    return 20;

                case VALUE.KING:
                    return 25;

                case VALUE.ACE:
                    return 30;

                default:
                    return 0;
            }
        }

        public int HowManyMatches(int number)
        {
            int count = 0;
            if(_ace == number)
            {
                count++;
            }
            if(_king == number)
            {
                count++;
            }
            if (_queen == number)
            {
                count++;
            }
            if (_jack == number)
            {
                count++;
            }
            if (_ten == number)
            {
                count++;
            }
            if (_nine == number)
            {
                count++;
            }
            if (_eight == number)
            {
                count++;
            }
            if (_seven == number)
            {
                count++;
            }
            if (_six == number)
            {
                count++;
            }
            if (_five == number)
            {
                count++;
            }
            if (_four == number)
            {
                count++;
            }
            if (_three == number)
            {
                count++;
            }
            if (_two == number)
            {
                count++;
            }

            return count;
        }

        public void ValuesCounter(Card[] _hand)
        {
            for (int i = 0; i < 5; i++)
            {
                VALUE value = _hand[i].MyValue;
                switch (value)
                {
                    case VALUE.ACE:
                        _ace++;
                        break;

                    case VALUE.KING:
                        _king++;
                        break;

                    case VALUE.QUEEN:
                        _queen++;
                        break;

                    case VALUE.JACK:
                        _jack++;
                        break;

                    case VALUE.TEN:
                        _ten++;
                        break;

                    case VALUE.NINE:
                        _nine++;
                        break;

                    case VALUE.EIGHT:
                        _eight++;
                        break;

                    case VALUE.SEVEN:
                        _seven++;
                        break;

                    case VALUE.SIX:
                        _six++;
                        break;

                    case VALUE.FIVE:
                        _five++;
                        break;

                    case VALUE.FOUR:
                        _four++;
                        break;

                    case VALUE.THREE:
                        _three++;
                        break;

                    case VALUE.TWO:
                        _two++;
                        break;

                    default:
                        break;
                }
            }
        }

        public void SuitesCounter(Card[] _hand)
        {
            for (int i = 0; i < 5; i++)
            {
                SUIT value = _hand[i].MySuit;
                switch (value)
                {
                    case SUIT.HEARTS:
                        _hearts++;
                        break;

                    case SUIT.SPADES:
                        _spades++;
                        break;

                    case SUIT.DIAMONDS:
                        _diamonds++;
                        break;

                    case SUIT.CLUBS:
                        _clubs++;
                        break;
                }
            }
        }
    }
}
