using System;
using System.Collections.Generic;
namespace ConsoleKisel1
{


    class Program
    {
        static void Main(string[] args)
        {

            List<Currency> CurrencyInfo = new List<Currency>(3);

            CurrencyInfo.Add(new Currency() { Rcd = 1, abb = "UAH", Name = "Гривня" });
            CurrencyInfo.Add(new Currency() { Rcd = 2, abb = "USD", Name = "Dollar" });
            CurrencyInfo.Add(new Currency() { Rcd = 3, abb = "EUR", Name = "Euro" });

            List<Сategory> СategoryInfo = new List<Сategory>(3);

            СategoryInfo.Add(new Сategory() { Rcd = 1, Name = "Зарплата", Type = (FlowType)1 });
            СategoryInfo.Add(new Сategory() { Rcd = 2, Name = "Бонусы", Type = (FlowType)1 });
            СategoryInfo.Add(new Сategory() { Rcd = 3, Name = "Еда", Type = (FlowType)2 });
            СategoryInfo.Add(new Сategory() { Rcd = 3, Name = "Бензин", Type = (FlowType)2 });
            СategoryInfo.Add(new Сategory() { Rcd = 3, Name = "Лечение", Type = (FlowType)2 });
            СategoryInfo.Add(new Сategory() { Rcd = 3, Name = "Игрушки", Type = (FlowType)2 });



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