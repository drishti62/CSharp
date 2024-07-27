class Real
{
    static void Main()
    {
        Console.WriteLine("Rnum");
        double Rnum = System.Convert.ToDouble;

        int notLessThanNumber = (int)Math.Ceiling(Rnum);
	int notGreaterThanNumber = (int)Math.Floor(Rnum);

        System.Console.WriteLine("Smallest integer: {Math.Ceiling(Rnum)}");
        System.Console.WriteLine("Largest integer: {Math.Floor(Rnum)}");
        System.Console.WriteLine("Not less than integer: {notLessThanNumber}");
        System.Console.WriteLine("Not greater than integer: {notGreaterThanNumber}");
    }
}
