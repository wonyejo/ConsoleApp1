using System;
using System.Threading;
public class Panda
{
	public string Name; //인스턴스 필드(인스턴스 변수)
	public static int Population; //정적 필드(공유 변수)

	public Panda(string n)
	{
		Name = n;
		Population += 1;
	}
}
class Program
{
	static void Main()
	{
		Panda p1 = new Panda("Pan Dee");
		Panda p2 = new Panda("Pan Dah");

		
		Console.WriteLine("p1의 이름: " + p1.Name + ", p2의 이름: " + p2.Name);
		Console.WriteLine(Panda.Population); //2
		Thread.Sleep(1000);
	}
}