using System;

public class MyString
{
    private string _text;

    public string Text
    {
        get => _text;
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Без пустых строк");
            }
            else
            {
                _text = value;
            }
        }
    }
    public MyString()
    {
        Text = "Default";
    }

    public MyString(string text)
    {
        if (text == null)
        {
            throw new ArgumentException("Без пустых строк");
        }
        Text = text;
    }

    public MyString(MyString other)
    {
        if (other.Text == null)
            throw new ArgumentException("Без пустых строк");
        Text = other.Text;
    }


    public string GetFirstAndLast()
    {
        if (string.IsNullOrEmpty(Text))
            return "Строка пуста";

        return Text.Length == 1 ? Text + Text : $"{Text[0]}{Text[^1]}";
    }


    public override string ToString()
    {
        return $"Text: {Text}";
    }
}


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
