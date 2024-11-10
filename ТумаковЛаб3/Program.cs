using System;
class Program
{
    static void Main(string[] args)
    {
        TaskL31();
        TaskL32();
        Task31();
    }

    // 3.1 Создать перечислимый тип данных с банковскими счетами (текущий и сберегательный).
    // Создать переменную типа перечисления, присвоить ей значение и вывести это значение на печать.

    enum AcctTypes
    {
        actual,
        saving,
    }
    static void TaskL31()
    {
        AcctTypes account = AcctTypes.saving;
        Console.WriteLine("Тип банковского счета: " + account);
    }

    // 3.2 Создать структуру, хранящую номер банковского счета, его тип и баланс.
    // Создать переменную такого типа, заполнить структуру значениями и вывести результат.

    struct BankAcc
    {
        /// <summary>
        /// Номер счета
        /// </summary>
        public string Number;
        /// <summary>
        /// Тип счета
        /// </summary>
        public AcctTypes Form; 
        /// <summary>
        /// Баланс
        /// </summary>
        public decimal Balance;
    }

    static void TaskL32()
    {
        BankAcc acc; 
        acc.Number = "25009";
        acc.Form = AcctTypes.actual;
        acc.Balance = 10000000;

        Console.WriteLine("Информация о банковском счете:");
        Console.WriteLine("Номер счета: " + acc.Number);
        Console.WriteLine("Тип счета: " + acc.Form);
        Console.WriteLine("Баланс: " + acc.Balance);
    }

    // 3.1 Создать перечислимый тип ВУЗ {КГУ, КАИ, КХТИ}.
    // Создать структуру работник с двумя полями: имя, ВУЗ.
    // Заполнить структуру данными и распечатать.

    enum VUZ
    {
        KGU,
        KAI,
        KHTI
    }

    struct Rabotnic
    {
        /// <summary>
        /// Имя 
        /// </summary>
        public string Name;
        /// <summary>
        /// ВУЗ
        /// </summary>
        public VUZ University;
    }

    static void Task31()
    {
        Rabotnic data;
        data.Name = "Роман";
        data.University = VUZ.KGU; 

        Console.WriteLine("имя: " + data.Name);
        Console.WriteLine("ВУЗ: " + data.University);
    }
}
















