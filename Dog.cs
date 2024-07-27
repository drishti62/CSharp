class Dog
{
 	public static int var1,var2;
}
class Animal
{
	public static void Main(string[] args)
	{
		Dog.var1=30;
		Dog.var2=45;
		System.Console.WriteLine(Dog.var1 + "\t" + Dog.var2);
	}
}