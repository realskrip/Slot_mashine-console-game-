using System;
using System.Collections.Generic;
using System.Text;

namespace Slot_machine
{
    class Menu
    {
        public uint selectMenu;
        public bool Exit = false;
        public void PrintMenu()
        {
            Console.WriteLine("\nМеню:\n" +
                "1. Пополнить банк\n" +
                "2. Сделать ставку\n" +
                "3. Играть\n" +
                "0. Выход\n");
        }


        public void MenuSel()
        {
            do
            {
                selectMenu = uint.Parse(Console.ReadLine());

                if (selectMenu >= 0 && selectMenu <= 3)
                {
                    switch (selectMenu)
                    {
                        case 1:
                            {
                                Bank Bank = new Bank();
                                Bank.Bank_replenishment();
                            }
                            break;
                        case 2:
                            {
                                Bet Bet = new Bet();
                                Bet.Make_a_bet_first();
                                Bet.Print_bet();
                            }
                            break;
                        case 3:
                            {
                                Game Game = new Game();
                                Bank Bank = new Bank();
                                Bet Bet = new Bet();

                                Game.Roll();
                                Game.Combination();
                                Bank.Print_bank();
                                Bet.Print_bet();
                            }
                            break;
                        case 0:
                            {
                                Exit = true;
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Выбранного пункта меню не существует! Выберите другой пункт.");
                }

            } while (!Exit);

            Console.WriteLine("Игра закончена!");    
        }
    }
}
