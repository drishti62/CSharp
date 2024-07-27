class Product
{
	public static void Main(string[] args)
  {  
	int n1, n2, n3, n4, ans ;
	System.Console.WriteLine("Enter 4 integer value =");
	n1 = System.Convert.ToInt32(args[0]);
	n2 = System.Convert.ToInt32(args[1]);
	n3 = System.Convert.ToInt32(args[2]);
	n4 = System.Convert.ToInt32(args[3]);
	ans = (n1 * n2 * n3 * n4);

	System.Console.WriteLine("ans of four integer number=" + ans);

  }
}
