class Fibonacci
{
	public static void Main(string[] args)
{
	int a, b, c, num, i;
	a = 0; 
	b = 1;
	i = 1;
	System.Console.WriteLine("Enter range of fibonacci series=");
	num = System.Convert.ToInt32(args[0]);
	System.Console.WriteLine(a + " " + b);
	while (i < num)
	{
		c= a + b;
		System.Console.WriteLine(" "+c);
		a = b;
		b = c;
		i++;
	}
}
}