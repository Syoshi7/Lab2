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
