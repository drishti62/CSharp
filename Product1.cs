class Product1
{
	public static void Main(string[] args)
	{
		int n1,n2,n3,n4,ans;
		
		n1= int.Parse(args[0]);
		n2= int.Parse(args[1]);
		n3= int.Parse(args[2]);
		n4= int.Parse(args[3]);
		ans= n1*n2*n3*n4;
		System.Console.WriteLine("product"  +ans);
	}
}