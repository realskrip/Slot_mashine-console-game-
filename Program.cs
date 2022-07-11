using System;

namespace Slot_machine
{
    class Program
    {
        static void Main()
        {
            WriteNameOfTheGame name = new WriteNameOfTheGame();              //Создание объекта класса для вывода названия игры
            RulesOfTheGame Rules = new RulesOfTheGame();                     //Создание объекта класса правила
            Bank Bank = new Bank();                                          //Создание объекта класса банка
            Bet Bet = new Bet();                                             //Создание объекта класса ставка
            Menu Menu = new Menu();


            name.WriteName();                                                //Вывод названия игры           
            Rules.PrintRules();                                              //Вывод правил игры           
            Bank.Bank_replenishment();                                       //Пополнение банка          
            Bank.Print_bank();                                               //Вывод счета банка
            Bet.Print_bet();                                                 //Вывод счета ставки
            Bet.Make_a_bet_first();                                          //Сделать первую ставку           

            Bank.Print_bank();
            Bet.Print_bet();
            Menu.PrintMenu();
            Menu.MenuSel();


        }
    }
}
