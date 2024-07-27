class Demo
{
	public static void Main(string[] args)
	{ 
		int a=10;
		object ob1=(object) a;
 		System.Console.WriteLine(ob1);
		int b=20;
		object ob2=(object) b;
		System.Console.WriteLine(ob2);
		int c =(int) ob1;
		System.Console.WriteLine(c);
	}
}