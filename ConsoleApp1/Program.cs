using System;
using System.Threading;

class Foo
{
    public static int X = Y; // Y 필드가 초기화되기 전에 X 필드가 초기화됨
    public static int Y = 3; // Y 필드 초기화 (3)

static Foo() // 정적 생성자
{
    Console.WriteLine("Static Constructor Called");
}
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Foo.X); // 출력 결과: 0 (X 필드 초기화)
        Thread.Sleep(3000);
    }
}


