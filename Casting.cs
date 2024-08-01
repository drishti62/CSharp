using System;
class Ro
{
	public void Calculations()
	{
		float sum;
		int i;
		sum=0.0F;
		for(i=1;i<=10;i++)
		{
			sum=sum+1/(float)i;
			System.Console.Write("i="+i);
			System.Console.WriteLine("sum="+sum);
		}
	}
}
class Casting
{
	public static void Main()
	{
		Ro obj1=new Ro();
		obj1.Calculations();
	}
}