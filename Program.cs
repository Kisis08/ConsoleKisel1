using System;

namespace ConsoleKisel1
{
    public class MoneyHis
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

    class Program
    {
        static void Main(string[] args)
        {
            MoneyHis Artem = new MoneyHis();
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