using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleKisel1
{


    public class Program
    {
         public static void Main(string[] args)
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

            Transaction Artem = new Transaction();

            // Artem.GetInfo();// до присвоения значений 
            Artem.Rcd = 1;
            Artem.Type = FlowType.input;
            Artem.Value = 5220F;
            Artem.Currency = 978;
            Artem.Category = 3;
            Artem.Note = "Причемание";
            Artem.DateOperation = (DateTime.Now);

            // Присвоение переменной ALALA значение, которое возвращает метод  VAL1
            var ALALA = VAL1(CurrencyInfo, Artem);
            Console.WriteLine($"Валюта: {ALALA.Rcd} {ALALA.Name}");

            // Присвоение переменной ALALA2 значение, которое возвращает метод  VAL2
            var ALALA2 = VAL2(CurrencyInfo, Artem);
            Console.WriteLine($"Валюта: {ALALA2.Rcd} {ALALA2.Name}");

            //for (int Vаl = 0; Vаl < CurrencyInfo.Count; Vаl++)
            //{
            //    if (CurrencyInfo[Vаl].Rcd == Artem.Currency)// Vаl - инструмент цикла. Необходимо сравнивать не с ним, а  с искомым значение из списка по которому бежит цикл в нашем случае это РЦД влаюты из списка CurrencyInfo
            //    {
            //        Console.WriteLine($"Валюта: {CurrencyInfo[Vаl].Rcd} {CurrencyInfo[Vаl].Name}");
            //        long CURRCD = CurrencyInfo[Vаl].Rcd;
            //        string CURName = CurrencyInfo[Vаl].Name;
            //       break;
            //    }
            //}
            //Console.WriteLine($"Валюта: {CURRCD} {CURName}");


            //for (int Vаl2 = 0; Vаl2 < СategoryInfo.Count; Vаl2++)
            //{
            //    if (СategoryInfo[Vаl2].Rcd == Artem.Category)// Vаl - инструмент цикла. Необходимо сравнивать не с ним, а  с искомым значение из списка по которому бежит цикл в нашем случае это РЦД влаюты из списка CurrencyInfo
            //    {
            //        Console.WriteLine($"Категория: {СategoryInfo[Vаl2].Rcd} {СategoryInfo[Vаl2].Name}");
            //        break;
            //    }
            //}
            //int i = 0;
            //while (i < CurrencyInfo.Count)
            //{
            //    Console.WriteLine($"Валюта: {CurrencyInfo[i].Name}  {CurrencyInfo[i].abb}");
            //    i++;
            //}

            //for (int а = 0; а < CurrencyInfo.Count; а++)
            //{
            //    Console.WriteLine($"Валюта: {CurrencyInfo[а].Name}  {CurrencyInfo[а].abb}");
            //}


            //foreach (Сategory aСategory in СategoryInfo)
            //{
            //    Console.WriteLine($"Категория: {aСategory.Name}");
            //}

            //Artem.GetInfo();
            //Console.ReadKey();

            //Передача структуры из метода (по памяти меньше, потому что просто ссылка)
            static Currency VAL1(List<Currency> CurrencyInfo, Transaction Artem)
            {
                for ( int Vаl = 0; Vаl < CurrencyInfo.Count; Vаl++)
              {
                    if (CurrencyInfo[Vаl].Rcd == Artem.Currency)// Vаl - инструмент цикла. Необходимо сравнивать не с ним, а  с искомым значение из списка по которому бежит цикл в нашем случае это РЦД влаюты из списка CurrencyInfo
                    {
                        //Console.WriteLine($"Валюта: {CurrencyInfo[Vаl].Rcd} {CurrencyInfo[Vаl].Name}");
                        return CurrencyInfo[Vаl];
                    }
                }
                //Console.WriteLine($"Валюта: {Rcd} {Name}");
                return null; 
            }

            //  Использование Tuple (кортежей) для вывода информации из метода
            static (long Rcd, string Name) VAL2(List<Currency> CurrencyInfo, Transaction Artem)
            {
                long Rcd = 0;
                string Name = "";
                for (int Vаl = 0; Vаl < CurrencyInfo.Count; Vаl++)
                {
                    if (CurrencyInfo[Vаl].Rcd == Artem.Currency)// Vаl - инструмент цикла. Необходимо сравнивать не с ним, а  с искомым значение из списка по которому бежит цикл в нашем случае это РЦД влаюты из списка CurrencyInfo
                    {
                        Rcd = CurrencyInfo[Vаl].Rcd;
                        Name = CurrencyInfo[Vаl].Name;
                        return (Rcd, Name);
                    }
                }
                return (Rcd, Name);
            }
        }  
    }                          
}