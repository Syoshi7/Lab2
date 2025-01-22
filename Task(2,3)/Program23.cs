using System;

class Program
{
    static void Main()
    {
        // Тестирование класса Time
        Time time1 = new Time();
        Console.WriteLine($"По умолчанию: " + time1.ToString());

        Time time2 = new Time(10, 45);
        Console.WriteLine($"Время2: " + time2.ToString());

        Time time3 = time2.AddMinutes(30);
        Console.WriteLine($"Добавление 30 минут: " + time3.ToString());

        Time time4 = time2.AddMinutes(120);
        Console.WriteLine($"Добавление 120 минут: " + time4.ToString());

        // Тестирование перегруженных операций
        Time time = new Time(10, 45);
        Console.WriteLine($"Время " + time.ToString());

        Time time100 = new Time(0, 59);
        Console.WriteLine($"Время2 " + time100.ToString());

        time++;
        Console.WriteLine($"Инкремент: " + time.ToString());

        time100++;
        Console.WriteLine($"Инкремент2: " + time100.ToString());

        time--;
        Console.WriteLine($"Декремент: " + time.ToString());

        byte hours = (byte)time;
        Console.WriteLine($"Конвертация в часы: " + hours);

        bool isNonZero = time;
        Console.WriteLine($"Проверка на ненулёвость: " + isNonZero);

        Time timePlus30 = time + 1000;
        Console.WriteLine($"Прибавка 1000 минут (16 часов и 40 минут) справа: " + timePlus30.ToString());

        Time timePlus30Rev = 30 + time;
        Console.WriteLine($"Прибавка 30 минут слева: " + timePlus30Rev.ToString());

        Time timeMinus30 = time - 10000;
        Console.WriteLine($"Вычитание 10000 минут справа:  " + timeMinus30.ToString());

        Time timeMinus30Rev = 30 - time;
        Console.WriteLine($"Вычитание 30 минут слева: " + timeMinus30Rev.ToString());
    }
}