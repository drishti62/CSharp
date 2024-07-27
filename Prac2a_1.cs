class Prac2a_1	
{		
	public static void Main(string[] args)
	{	
		System.Console.WriteLine("Enter the value");
		int number = int.Parse(System.Console.ReadLine());
		System.Console.WriteLine(number);
		
		if (number < 0)
		{
			System.Console.WriteLine("the value is invalid");
		}
		else
		{
			
			long fact = fact_fn(number);
			System.Console.WriteLine("the factorial is = {0}",fact); 
		}
	}	
		
	static long fact_fn(int num)
	{	
		long res = 1;
		for(int i = 1; i <= num ; i++)
		{
			res *= i;
		}
		return res;
	}	
}		