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
            Console.WriteLine();
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
                        if (Bank.bank >= 100)
                        {
                            Bank.bank -= 100;
                            bet += 100;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Недостаточно средств! Пополните банк.");
                        }
                    }
                    break;
                case 2:
                    {
                        if (Bank.bank >= 200)
                        {
                            Bank.bank -= 200;
                            bet += 200;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Недостаточно средств! Пополните банк.");
                        }
                    }
                    break;
                case 3:
                    {
                        if (Bank.bank >= 500)
                        {
                            Bank.bank -= 500;
                            bet += 500;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Недостаточно средств! Пополните банк.");
                        }
                    }
                    break;
                case 4:
                    {
                        if (Bank.bank >= 1000)
                        {
                            Bank.bank -= 1000;
                            bet += 1000;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Недостаточно средств! Пополните банк.");
                        }
                    }
                    break;
                case 5:
                    {
                        if (Bank.bank >= 2000)
                        {
                            Bank.bank -= 2000;
                            bet += 2000;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Недостаточно средств! Пополните банк.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Можно делать только фиксированную ставку! Выберите ставку из списка.");
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
