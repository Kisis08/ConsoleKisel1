using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Diagnostics;
using System.Threading;

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
            Artem.Category = 2;
            Artem.Note = "Причемание";
            Artem.DateOperation = (DateTime.Now);

            // Присвоение переменной CurInfo значение, которое возвращает метод  CurrencyGet
            var CurInfo = CurrencyGet(CurrencyInfo, Artem);
            Console.WriteLine($"Валюта: {CurInfo.Rcd} {CurInfo.Name}");

            // Присвоение переменной CatInfo значение, которое возвращает метод  СategoryGet
            var CatInfo = СategoryGet(СategoryInfo, Artem);
            Console.WriteLine($"Категория: {CatInfo.Rcd} {CatInfo.Name}");

            GetInfo(Artem);
            MainMenu();
            //Artem.GetInfo();
            //Console.ReadKey();

            //Передача структуры из метода (по памяти меньше, потому что просто ссылка)
            static Currency CurrencyGet (List<Currency> CurrencyInfo, Transaction Artem)
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

            static Сategory СategoryGet(List<Сategory> СategoryInfo, Transaction Artem)
            {
                for (int Vаl = 0; Vаl < СategoryInfo.Count; Vаl++)
                {
                    if (СategoryInfo[Vаl].Rcd == Artem.Category)// Vаl - инструмент цикла. Необходимо сравнивать не с ним, а  с искомым значение из списка по которому бежит цикл в нашем случае это РЦД влаюты из списка CurrencyInfo
                    {
                        //Console.WriteLine($"Валюта: {CurrencyInfo[Vаl].Rcd} {CurrencyInfo[Vаl].Name}");
                        return СategoryInfo[Vаl];
                    }
                }
                return null;
            }


             void GetInfo(Transaction Artem)

                {
                    Console.WriteLine($"Транзакция за {Artem.DateOperation} \nТип: {Artem.Type}  \nСумма: {Artem.Value} \nВалюта: {Artem.Currency} \nКатегория: {Artem.Category}");
                }

              static void CloseProgram()
                 {
                Environment.Exit(0);
                 }

            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Выберите один из следующих вариантов:");
                Console.WriteLine("1) Просмотреть доступные тразакции");
                Console.WriteLine("2) Просмотреть доступные категории");
                Console.WriteLine("3) Просмотреть доступные валюты");
                Console.WriteLine("4) Выход");
                Console.Write("\r\nСделайте выбор: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        GetInfo(Artem);
                        return true;
                    case "2":
                        Console.WriteLine($"Категория: {CatInfo.Rcd} {CatInfo.Name}");
                        return true;
                    case "3":
                        Console.WriteLine($"Валюта: {CurInfo.Rcd} {CurInfo.Name}");
                        return true;
                    case "4":
                        CloseProgram();
                        return false;
                    default:
                        return true;
                }
            }

        }  
    }                          
}