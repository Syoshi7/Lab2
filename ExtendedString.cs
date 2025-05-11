using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ExtendedString : MyString
    {
        private int _length;

        public int Lenght
        {
            get => _length;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Длина строки не может быть отрицательной");
                _length = value;
            }
        }

        public ExtendedString() : base(" ")
        {
            Lenght = 1;
        }

        public ExtendedString(string text, int length)
            : base(text)
        {
            Lenght = length;
        }


        public ExtendedString(ExtendedString other) : base(other)
        {
            Lenght = other.Lenght;
        }


        public int CountVowels()
        {
            int count = 0;
            string vowels = "AEIOUaeiouАЕЁИОУЫЭЮЯаеёиоуыэюя";

            foreach (char c in Text)
            {
                if (vowels.Contains(c))
                    count++;
            }

            return count;
        }


        public string ReverseText()
        {
            char[] charArray = Text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public override string ToString()
        {
            return $"Text: {Text}, Length: {Lenght}";
        }
    }
}
