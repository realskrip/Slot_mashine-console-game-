using System;
using System.Collections.Generic;
using System.Text;

namespace Slot_machine
{
    class Bet
    {
        public static uint bet = 0;
        public uint select_make_a_bet_first;

        public void Make_a_bet_first()
        {
            Console.WriteLine("Какую ставку вы хотите сделать?");
            Console.WriteLine
                ("1. 100\n" +
                "2. 200\n" +
                "3. 500\n" +
                "4. 1000\n" +
                "5. 2000\n");
            Console.WriteLine();

            select_make_a_bet_first = uint.Parse(Console.ReadLine());

            switch (select_make_a_bet_first)
            {
                case 1:
                    {
                        Bank.bank -= 100;
                        bet += 100;
                    }
                    break;
                case 2:
                    {
                        Bank.bank -= 200;
                        bet += 200;
                    }
                    break;
                case 3:
                    {
                        Bank.bank -= 500;
                        bet += 500;
                    }
                    break;
                case 4:
                    {
                        Bank.bank -= 1000;
                        bet += 1000;
                    }
                    break;
                case 5:
                    {
                        Bank.bank -= 2000;
                        bet += 2000;
                    }
                    break;
                default:
                    Console.WriteLine("Попробуйте ещё раз!");
                    break;
            }
        }

        public void Print_bet()
        {
            Console.Write("Ставка " + bet);
            Console.WriteLine();
        }
    }
}
