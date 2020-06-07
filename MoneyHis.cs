using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleKisel1
{
    public class MoneyHis
    {
        public long Rcd; //ID-запси
        public byte Type; //Тип записи (0-расход, 1 - приход)
        public float Value; //Сумма транзакции  
        public string Currency; //Валюта, пока только "грн."
        public byte Category; //Категория (Связь с классом MoneyСategory)
        public string Note; // Примечание   
        public DateTime DateCreate = (DateTime.Now); //Дата создания записи
        public DateTime DateOperation;  //Дата транзакции

        public void GetInfo()
        {
            Console.WriteLine($"Тип: {Type}  Сумма: {Value}");
        }
    }
}
