// program to read number from keyboard and print following in 1 line smallest interger largest interger not less than and not greater than
class KeyReader
{
	public static void Main(string[] args)
	{
		int a,b;
		System.Console.WriteLine("enter the value:");
		a = System.Convert.ToInt32(args[0]);
		b = System.Convert.ToInt32(args[1]);
		if(a<b)
		{
			System.Console.WriteLine(a+" is great");
		}
		else
		{
			System.Console.WriteLine(b+" is great");
		}
	}
}