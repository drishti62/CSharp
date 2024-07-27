class Reverse
{
	public static void Main(string[] args)
	{
	int num,rev,sum;
	sum = 0;
	System.Console.WriteLine("Enter number=");
	num = System.Convert.ToInt32(args[0]);
	while (num > 0)
	{
	rev = num % 10;
	System.Console.WriteLine(rev);
	sum = sum + rev;
	num = num / 10;
	}
	}
}





