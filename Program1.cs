using System.Text;

namespace Lab2
{
    public class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;

                //Тесты конструкторов
                MyString string1 = new MyString();
                string1.Text = "Строка1";

                MyString string2 = new MyString("Строка2");
                MyString string3 = new MyString(string2);

                //Тесты методов String
                Console.WriteLine("\nВывод всех имеющихся строк: ");
                Console.WriteLine($"MyString1: {string1}");
                Console.WriteLine($"MyString2: {string2}");
                Console.WriteLine($"MyString3: {string3}");
                Console.WriteLine("\n\nВывод первого и последнего символа каждой строки: ");
                Console.WriteLine($"{string1.GetFirstAndLast()}, {string2.GetFirstAndLast()}, {string3.GetFirstAndLast()}");

                //тесты дочернего класса ExtendedString
                ExtendedString EString1 = new ExtendedString();
                EString1.Text = "РасширеннаяСтрока1";
                EString1.Lenght = 18;

                ExtendedString EString2 = new ExtendedString("РасширеннаяСтрока2", 18);
                Console.WriteLine("\nВывод всех имеющихся расширенных строк: ");
                Console.WriteLine($"EString1: {EString1}");
                Console.WriteLine($"EString2: {EString2}");

                Console.WriteLine($"Гласные в Estring1: {EString1.CountVowels()}");
                Console.WriteLine($"Гласные в Estring2: {EString2.CountVowels()}");

                Console.WriteLine($"Текст наоборот в Estring1: {EString1.ReverseText()}");
                Console.WriteLine($"Текст наоборот в Estring2: {EString2.ReverseText()}");

                Console.WriteLine($"Первый и последний символ в EString 1: {EString1.GetFirstAndLast()}");
                Console.WriteLine($"Первый и последний символ в EString 2: {EString2.GetFirstAndLast()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Получено и обработано исключение неправильного аргумента: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Получено и обработано исключение: {ex.Message}");
            }
        }
    }
}
