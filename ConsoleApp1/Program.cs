using System;

public class UnitConverter
{
    int ratio; //필드, data member
    public UnitConverter(int unitRatio) { ratio = unitRatio; } //생성자, function member
    public double Convert(int unit) { return unit * ratio; } //메서드, function member
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Input any Meter 값");
        UnitConverter MtoMMConverter = new UnitConverter(1000);
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine(MtoMMConverter.Convert(height) + " millimeter");
    }
}