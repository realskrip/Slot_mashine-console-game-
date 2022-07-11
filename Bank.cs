using System;
using System.Collections.Generic;
using System.Text;

namespace Slot_machine
{
    class Bank
    {
        public static uint bank = 0;

        public void Bank_replenishment()
        {
            Console.WriteLine();
            Console.WriteLine("Введите сумму, которую вы хотите внести в банк");            
            bank += uint.Parse(Console.ReadLine());
            Console.WriteLine();
        } 
        
        public void Print_bank()
        {
            Console.Write("\nБанк " + bank);
            Console.WriteLine();
        }
    }
}
