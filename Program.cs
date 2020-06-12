using System;
using System.Collections.Generic;
namespace ConsoleKisel1
{


    class Program
    {
        static void Main(string[] args)
        {

            List<Currency> CurrencyInfo = new List<Currency>(3);

            CurrencyInfo.Add(new Currency() { Rcd = 980, abb = "UAH", Name = "Гривня" });
            CurrencyInfo.Add(new Currency() { Rcd = 840, abb = "USD", Name = "Dollar" });
            CurrencyInfo.Add(new Currency() { Rcd = 978, abb = "EUR", Name = "Euro" });
            CurrencyInfo.Add(new Currency() { Rcd = 643, abb = "RUB", Name = "Рубль" });

            List<Сategory> СategoryInfo = new List<Сategory>(3);

            СategoryInfo.Add(new Сategory() { Rcd = 1, Name = "Зарплата", Type = FlowType.input});
            СategoryInfo.Add(new Сategory() { Rcd = 2, Name = "Бонусы", Type = FlowType.input });
            СategoryInfo.Add(new Сategory() { Rcd = 3, Name = "Еда", Type = FlowType.output });
            СategoryInfo.Add(new Сategory() { Rcd = 4, Name = "Бензин", Type = FlowType.output });
            СategoryInfo.Add(new Сategory() { Rcd = 5, Name = "Лечение", Type = FlowType.output });
            СategoryInfo.Add(new Сategory() { Rcd = 6, Name = "Игрушки", Type = FlowType.output });

            int i = 0;
            while (i < CurrencyInfo.Count)
            {
                Console.WriteLine($"Валюта: {CurrencyInfo[i].Name}  {CurrencyInfo[i].abb}");
                i++;
            }

            for (int а = 0; а < CurrencyInfo.Count; а++)
            {
                Console.WriteLine($"Валюта: {CurrencyInfo[а].Name}  {CurrencyInfo[а].abb}");
            }

            foreach (Сategory aСategory in СategoryInfo)
            {
                Console.WriteLine($"Категория: {aСategory.Name}");
            }



            Transaction Artem = new Transaction();

                // Artem.GetInfo();// до присвоения значений 
                Artem.Rcd = 1;
                Artem.Type = FlowType.input;
                Artem. Value = 5220F;
                Artem.Currency = 978;
                Artem.Category = 500;
                Artem.Note = "Причемание";
                Artem.DateOperation = (DateTime.Now);

            //Artem.GetInfo();
            //Console.ReadKey();

            for (int Vаl = 0; Vаl < CurrencyInfo.Count; Vаl++)
            {
               if (CurrencyInfo[Vаl].Rcd == Artem.Currency)// Vаl - инструмент цикла. Необходимо сравнивать не с ним, а  с искомым значение из списка по которому бежит цикл в нашем случае это РЦД влаюты из списка CurrencyInfo
                {
                Console.WriteLine($"Валюта: {CurrencyInfo[Vаl].Rcd} {CurrencyInfo[Vаl].Name}");
                    break;
                }
           

            }

            //for (int z = 0; z < 9; z++)
            //{
            //    if (z == 5)
            //        break;
            //    Console.WriteLine(z);
            //}



        }


    }            
                 
}