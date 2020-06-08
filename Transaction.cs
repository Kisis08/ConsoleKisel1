using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleKisel1
{
    class Transaction
    {
        public long Rcd; //ID-запси
        public byte Type; //Тип записи (0-расход, 1 - приход)
        public float Value; //Сумма транзакции  
        public object Currency; //Валюта, пока только "грн."
        public object Category; //Категория (Связь с классом MoneyСategory)
        public object Note; // Примечание   
        public DateTime DateCreate = (DateTime.Now); //Дата создания записи
        public DateTime DateOperation;  //Дата транзакции

        public void GetInfo()
        {
            Console.WriteLine($"Транзакция за {DateOperation} \nТип: {Type}  \nСумма: {Value} \nВалюта: {Currency} \nКатегория: {Category}");
        }
    }
}
