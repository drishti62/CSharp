class Ro
{
	public void Calculations()
	{
		int m=10,n=20;
		System.Console.WriteLine("m="+m);
		System.Console.WriteLine("n="+n);
		System.Console.WriteLine("++m="+ ++m);
		System.Console.WriteLine("n++="+ n++);
		System.Console.WriteLine("m="+m);
		System.Console.WriteLine("m="+m);
	}
}
class IncrementOperators
{
	public static void Main()
	{
		Ro obj1=new Ro();
		obj1.Calculations();
	}
}
		