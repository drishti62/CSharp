class Float
{
	public void Calculation()
	{
		float a=20.5F,b=6.4F;
		System.Console.WriteLine("a="+a);
		System.Console.WriteLine("b="+b);
		System.Console.WriteLine("a+b="+(a+b));
		System.Console.WriteLine("a-b="+(a-b));
		System.Console.WriteLine("a*b="+(a*b));
		System.Console.WriteLine("a/b="+(a/b));
		System.Console.WriteLine("a%b="+(a%b));
	}
}
class Floatpoint
{
	public static void Main()
	{
		Float obj1=new Float();
		obj1.Calculation();
	}
}
