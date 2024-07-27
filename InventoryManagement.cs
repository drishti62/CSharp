class InventoryManagement
{
	 public static void Main(string[] args)
	{
		int dr,sc,cpu;
		double EOQ,TBO;
		dr = System.Convert.ToInt32(args[0]);
		sc = System.Convert.ToInt32(args[1]);
		cpu = System.Convert.ToInt32(args[2]);
		EOQ = System.Math.Sqrt(2*dr*sc/cpu);
		TBO = System.Math.Sqrt(2*sc/(dr*cpu));
		System.Console.WriteLine("EOQ = {0} and TBO = {1}",EOQ,TBO);
	}
}