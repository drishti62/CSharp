class Prime
{
	public static void Main(string[] args)
	{
		int n,a,i;
		System.Console.WriteLine("Enter the number=");
		n = IntParse(args[0]);
		for(i=1; i<=n; i++)
		{
		if(n%1==0)
		{
		a++;
		}
		}
		if(a==2)
		{
		System.Console.WriteLine("{0} is a prime number",n);
		}
		else
		{
		System.Console.WriteLine("Not a Prime number");
		}
	}
}