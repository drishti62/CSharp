class BoxUnBox
{
	public static void Main(string[] args){
		int  a = 10;
		object ob1 = (object)a;
		System.Console.WriteLine(ob1);

		int b = 10;
		object ob2 = b;//boxing value

		int c = (int)ob2;//unboxing
		System.Console.WriteLine(ob2);
		System.Console.WriteLine(c);		
	}
}