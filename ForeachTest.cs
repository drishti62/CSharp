class ForeachTest
{
	public static void Main(string[] args)
	{
		int[ ] arrayInt = { 11,22,33,44};
		foreach ( int m in arrayInt)
		{
			System.Console.Write(" "+m);
		}
		System.Console.WriteLine();
	}
}