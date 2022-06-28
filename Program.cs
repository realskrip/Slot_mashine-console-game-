using System;

namespace Slot_machine
{
    class Program
    {
        static void Main()
        {
            WriteNameOfTheGame name = new WriteNameOfTheGame();          //Создание объекта класса для вывода названия игры
            name.WriteName();                                            //Вывод названия игры

            RulesOfTheGame Rules = new RulesOfTheGame();                 //Создание объекта класса правила
            Rules.PrintRules();                                          //Вывод правил игры

            Bank Bank = new Bank();                                      //Создание объекта класса банка
            Bank.Bank_replenishment();                                   //Пополнение банка
            
            Bet Bet = new Bet();                                         //Создание объекта класса ставка

            Bank.Print_bank();                                           //Вывод счета банка
            Bet.Print_bet();                                             //Вывод счета ставки

            Bet.Make_a_bet_first();                                      //Сделать первую ставку

            Bank.Print_bank();                                           //Вывод счета банка
            Bet.Print_bet();                                             //Вывод счета ставки

            Menu Menu = new Menu();
            Menu.PrintMenu();
            Menu.MenuSel();


        }
    }
}
