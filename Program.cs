using System;
using System.Collections.Generic;
namespace ConsoleKisel1
{


    class Program
    {
        static void Main(string[] args)
        {

            List<Currency> abb = new List<Currency>(3);

                abb.Add(new Currency() { abb = "UAH" });
                abb.Add(new Currency() { abb = "USD" });
                abb.Add(new Currency() { abb = "EUR" });

            Transaction Artem = new Transaction();

                // Artem.GetInfo();// до присвоения значений 
                Artem.Rcd = 1;
                Artem.Type = FlowType.input;
                Artem. Value = 5220F;
                Artem.Currency = 1;
                Artem.Category = 500;
                Artem.Note = "Причемание";
                Artem.DateOperation = (DateTime.Now);
      
            Artem.GetInfo();
            Console.ReadKey();


        }


    }            
                 
}