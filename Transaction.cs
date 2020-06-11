using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleKisel1
{
    class Transaction
    {
        public long Rcd; //ID-запси
        public FlowType Type; //Тип записи (0-расход, 1 - приход)
        public float Value; //Сумма транзакции  
        public long Currency;  //Валюта, пока только "грн."
        public long Category; //Категория (Связь с классом Сategory)
        public string Note; // Примечание   
        public DateTime DateCreate = (DateTime.Now); //Дата создания записи
        public DateTime DateOperation;  //Дата транзакции

        public void GetInfo()
        {
            Console.WriteLine($"Транзакция за {DateOperation} \nТип: {Type}  \nСумма: {Value} \nВалюта: {Currency} \nКатегория: {Category}");
        }
    }
}
