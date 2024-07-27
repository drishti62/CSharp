class Prac2a_2
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Money Convertor");

		const double tousd = 0.012;
		const  double toinr = 83.33;

		while(true)
		{
			System.Console.WriteLine("Choose Option");
			System.Console.WriteLine("\n1.USD to INR");
			System.Console.WriteLine("\n2.INR to USD");
			System.Console.WriteLine("\n3.EXIT");
			System.Console.WriteLine("\nEnter your Choice");

			string choice = System.Console.ReadLine();

			if (choice == "1")
			{
				System.Console.WriteLine("Enter the Amount(USD) = ");
				double usd = System.Convert.ToDouble(System.Console.ReadLine());
				double inr = usd * toinr;
				System.Console.WriteLine("\n{0} $ = {1} rs\n",usd,inr);
			}

			if (choice == "2")
			{
				System.Console.WriteLine("Enter the Amount(INR) = ");
				double inr = System.Convert.ToDouble(System.Console.ReadLine());
				double usd = inr * tousd;
				System.Console.WriteLine("{0} rs = {1} $\n",inr,usd);
			}

			else if (choice == "3")
            		{
                		System.Console.WriteLine("Exiting the program.");
                		break;
            		}

            		else
            		{
                		System.Console.WriteLine("Invalid choice. Please try again.");
            		}
		}
	}
}