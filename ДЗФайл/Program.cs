using System;

class Program
{
    static void Main(string[] args)
    {
        Task2();
        Task4();
        Task5();
        // 3 
        Console.WriteLine("введите строку: ");
        string stroka = Console.ReadLine();
        string newStroka = ToggleCase(stroka);
        Console.WriteLine("новая строка: " + newStroka);
    }

    // 2 напишите программу, в которой принимаются данные пользователя: имя, город, возраст и PIN-код.
    // Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.
    struct Data
    {
        /// <summary>
        /// имя
        /// </summary>
        public string Name;
        /// <summary>
        /// город
        /// </summary>
        public string City;
        /// <summary>
        /// возраст
        /// </summary>
        public int Age;
        /// <summary>
        /// пин-код
        /// </summary>
        public int PIN;
    }

    static void Task2()
    {
        Data personalData;
        Console.Write("введите свое имя: ");
        personalData.Name = Console.ReadLine();
        Console.Write("введите свой город: ");
        personalData.City = Console.ReadLine();
        Console.Write("введите свой возраст: ");
        personalData.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите свой пин-код: ");
        personalData.PIN = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("имя: " + personalData.Name);
        Console.WriteLine("город: " + personalData.City);
        Console.WriteLine("возраст: " + personalData.Age);
        Console.WriteLine("пин-код: " + personalData.PIN);
    }

    // 3 Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.
    static string ToggleCase(string str)
    {
        char[] NewChar = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            char s = str[i];
            if (char.IsUpper(s))
            {
                NewChar[i] = char.ToLower(s);
            }
            else
            {
                NewChar[i] = char.ToUpper(s);
            }
        }

        return new string(NewChar);
    }

    // 4 Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.
    static void Task4()
    {
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();
        Console.WriteLine("Введите подстроку для поиска: ");
        string podstroka = Console.ReadLine();
        int vhod = VhodCount(stroka, podstroka);
        Console.WriteLine($"к-во вхождений подстроки '{podstroka}' в строку: {vhod}");
    }

    static int VhodCount(string stroka, string podstroka)
    {
        if (string.IsNullOrEmpty(stroka) || string.IsNullOrEmpty(podstroka))
        {
            return 0;
        }

        int count = 0;
        int index = 0;

        while ((index = stroka.IndexOf(podstroka, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += podstroka.Length;
        }
        
        return count;
    }

    // 5 Определить к-во бутылок виски беспошлинной торговли, которые нужно будет купить,
    // чтобы экономия покрыла расходы на отпуск. 
    static void Task5()
    {
        Console.WriteLine("введите нормальную цену");
        int normPrice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите скидку в дюти фри в процентах");
        int salePrice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите стоимость отпуска");
        int holidayPrice = Convert.ToInt32(Console.ReadLine());
        double sale = normPrice * (1 - salePrice / 100.0);
        double SaveBottle = normPrice - salePrice;
        int butylki = (int)(holidayPrice / SaveBottle);
        Console.WriteLine("количество бутылок: " + butylki);
    }
}
