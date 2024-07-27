class Celsius
{
    static void Main(string[] args)
    {
        double F= System.Convert.ToInt32(args[0]);
        double Celsius = (F-32)/1.8;
        System.Console.WriteLine(Celsius);
        
    }
}


