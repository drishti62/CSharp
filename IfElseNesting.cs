using System;
class Expression
{
	public void demo()
	{
		int a = 325, b = 712, c = 478;
		Console.Write("Largest Value is: ");
		if (a > b)
		{
			if(a > c)
			{
				Console.WriteLine(a);
			}
			else
			{
				Console.WriteLine(c);
			}
		}
		else
		{
			if(c > b)
			{
				Console.WriteLine(c);
			}
		else
		{
			Console.WriteLine(b);
		}
	}
}
}
class IfElseNesting
{
	public static void Main(string[] args)
	{
		Expression obj1=new Expression();
		obj1.demo();
	}
}