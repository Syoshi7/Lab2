using System;

public class Time
{
    private byte hours;
    private byte minutes;

    public byte Hours
    {
        get { return hours; }
        set
        {
            if (value >= 0 && value < 24)
                hours = value;
            else
                throw new ArgumentOutOfRangeException("Часы должны быть от 0 до 23");
        }
    }

    public byte Minutes
    {
        get { return minutes; }
        set
        {
            if (value >= 0 && value < 60)
                minutes = value;
            else
                throw new ArgumentOutOfRangeException("Число минут должно быть от 0 до 59.");
        }
    }

    public Time()
    {
        hours = 0;
        minutes = 0;
    }

    public Time(byte hours, byte minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public Time AddMinutes(uint minutesToAdd)
    {
        uint totalMinutes = (uint)hours * 60 + minutes + minutesToAdd;
        byte newHours = (byte)((totalMinutes / 60) % 24);
        byte newMinutes = (byte)(totalMinutes % 60);
        return new Time(newHours, newMinutes);
    }

    public override string ToString()
    {
        return $"{hours:D2}:{minutes:D2}";
    }

    // Унарные операции
    public static Time operator ++(Time t)
    {
        return t.AddMinutes(1);
    }

    public static Time operator --(Time t)
    {
        uint totalMinutes = (uint)t.hours * 60 + t.minutes;
        if (totalMinutes == 0)
            totalMinutes = 24 * 60;
        return t.AddMinutes(unchecked((uint)-1));
    }

    // Операции приведения типа
    public static explicit operator byte(Time t)
    {
        return t.hours;
    }

    public static implicit operator bool(Time t)
    {
        return t.hours != 0 || t.minutes != 0;
    }

    // Бинарные операции
    public static Time operator +(Time t, uint minutes)
    {
        return t.AddMinutes(minutes);
    }

    public static Time operator +(uint minutes, Time t)
    {
        return t.AddMinutes(minutes);
    }

    public static Time operator -(Time t, uint minutes)
    {
        uint totalMinutes = (uint)t.hours * 60 + t.minutes;
        if (totalMinutes < minutes)
            totalMinutes = 24 * 60 + totalMinutes;
        return t.AddMinutes(unchecked((uint)-minutes));
    }

    public static Time operator -(uint minutes, Time t)
    {
        uint totalMinutes = (uint)t.hours * 60 + t.minutes;
        if (totalMinutes < minutes)
            totalMinutes = 24 * 60 + totalMinutes;
        return t.AddMinutes(unchecked((uint)-minutes));
    }
}