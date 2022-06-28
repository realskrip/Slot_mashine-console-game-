using System;
using System.Collections.Generic;
using System.Text;

namespace Slot_machine
{
    class Game
    {
        static char[] mySymbol = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '$' };

        char firstRandom, secondRandom, thirdRandom;

        Random rnd = new Random();

        public void Roll()
        {
            char randomSymbol1 = mySymbol[rnd.Next(0, mySymbol.Length)];
            firstRandom = randomSymbol1;

            char randomSymbol2 = mySymbol[rnd.Next(0, mySymbol.Length)];
            secondRandom = randomSymbol2;

            char randomSymbol3 = mySymbol[rnd.Next(0, mySymbol.Length)];
            thirdRandom = randomSymbol3;

            Console.WriteLine($"{firstRandom}{secondRandom}{thirdRandom}");
        }

        public void Combination()
        {
            if (firstRandom == secondRandom && firstRandom == thirdRandom)
            {
                if (firstRandom == '$')
                {
                    Bet.bet *= 10;
                    Bank.bank += Bet.bet;
                }
                else if (firstRandom == '2')
                {
                    Bet.bet *= 2;
                    Bank.bank += Bet.bet;
                }
                else if (firstRandom == '3')
                {
                    Bet.bet *= 3;
                    Bank.bank += Bet.bet;
                }
                else if (firstRandom == '4')
                {
                    Bet.bet *= 4;
                    Bank.bank += Bet.bet;
                }
                else if (firstRandom == '5')
                {
                    Bet.bet *= 5;
                    Bank.bank += Bet.bet;
                }
                else if (firstRandom == '6')
                {
                    Bet.bet *= 6;
                    Bank.bank += Bet.bet;
                }
                else if (firstRandom == '7')
                {
                    Bet.bet *= 7;
                    Bank.bank += Bet.bet;
                }
                else if (firstRandom == '8')
                {
                    Bet.bet *= 8;
                    Bank.bank += Bet.bet;
                }
                else if (firstRandom == '9')
                {
                    Bet.bet *= 9;
                    Bank.bank += Bet.bet;
                }

            }
            else
            {
                Bank.bank -= Bet.bet;
            }
        }
    }
}
