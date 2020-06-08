using System;

namespace ConsoleKisel1
{


    class Program
    {
        static void Main(string[] args)
        {
            Transaction Artem = new Transaction();
            // Artem.GetInfo();// до присвоения значений 


            Artem.Rcd = 1; 
            Artem.Type = 0;
            Artem. Value = 5220F;
            Artem.Currency = "UAH";
            Artem.Category = "Офф зарплата";
            Artem.Note = "Причемание";
            Artem.DateOperation = (DateTime.Now);
          

            Artem.GetInfo();
            Console.ReadKey();
        }
    }            
                 
}