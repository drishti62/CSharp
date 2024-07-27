
    class Program
    {
        static void Main(string[] args)
        {
            double price = System.Convert.ToDouble(args[0]);
	    int paise = (int)(price * 100);
	    System.Console.WriteLine(paise);
        }
    }






