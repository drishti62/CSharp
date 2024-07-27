class Travel
{
	public static void Main(string[] args)
	{
	double u = System.Convert.ToDouble(args[0]);
	double a = System.Convert.ToDouble(args[1]);
	double t = System.Convert.ToDouble(args[2]);
	double p = a*t;
	double dis = u*t + p*p/ 2;
	System.Console.WriteLine("Distance Travel " + dis);
	}	

}