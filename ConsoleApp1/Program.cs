using System;
using System.Threading;

class Sentence
{
    string[] words = "The quick brown fox".Split();

    public string this[int wordNum] // 인덱서
    {
        get { return words[wordNum]; }
        set { words[wordNum] = value; }
    }
    static void Main()

    {
        Sentence s = new Sentence();
        Console.WriteLine(s[3]); // fox
        s[3] = "kangaroo";
        Console.WriteLine(s[3]); // kangaroo
        Thread.Sleep(3000);
    }
}