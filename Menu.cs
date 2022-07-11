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
                                Bet Bet = new Bet();
                                Menu Menu = new Menu();

                                Bank.Bank_replenishment();
                                Bank.Print_bank();
                                Bet.Print_bet();
                                Menu.PrintMenu();
                            }
                            break;
                        case 2:
                            {
                                Bet Bet = new Bet();
                                Bank Bank = new Bank();
                                Menu Menu = new Menu();

                                Bet.Make_a_bet_first();
                                Bank.Print_bank();
                                Bet.Print_bet();
                                Menu.PrintMenu();

                            }
                            break;
                        case 3:
                            {

                                Game Game = new Game();
                                Bank Bank = new Bank();
                                Bet Bet = new Bet();
                                Menu Menu = new Menu();

                                if (Bet.bet != 0)
                                {
                                    Game.Roll();
                                    Game.Combination();
                                    Bank.Print_bank();
                                    Bet.Print_bet();
                                    Menu.PrintMenu();
                                }
                                else if (Bet.bet == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Сделайте ставку!");
                                    Menu.PrintMenu();
                                }
                                
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
                    Menu Menu = new Menu();

                    Console.WriteLine();
                    Console.WriteLine("Ошибка! Выбранного пункта меню не существует! Выберите другой пункт.");
                    Menu.PrintMenu();
                }

            } while (!Exit);

            Console.WriteLine();
            Console.WriteLine("Игра закончена!");    
        }
    }
}
