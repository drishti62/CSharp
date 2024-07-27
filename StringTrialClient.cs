class StringTrial
{
	string str1,str2,str3;
	string str4,str5;

	public static void Display()
	{
		str1=@"C:\tyit";
		str2="c:\\class";
		//str3="c:\class";
		str3=System.String.Empty;

		System.Console.WriteLine("str1 = {0} \nstr2 = {1} \nstr3 = {2}",str1,str2,str3);

		str4 = "A";
		str5 = "J";
		System.Console.WriteLine("str4 = {0} \nstr5 = {1} \nstr_op = {2} ",str4,str5,System.String.Compare(str4,str5));
		System.Console.WriteLine("str4 = {0} \nstr5 = {1} \nstr_op = {2} ",str4,str5,str4.CompareTo(str5));
		
		System.Console.WriteLine("str4 = {0} \nstr5 = {1} \nstr_op = {2} ",str4,str5,System.String.Concat(str2,str1));
		System.Console.WriteLine("str4 = {0} \nstr5 = {1} \nstr_op = {2} ",str4,str5,str1.Contains("it"));
		//System.Console.WriteLine("\nstr_op = {0}",System.String.Copy
	}
}
class StringTrialClient
{
	public static void Main()
	{
	StringTrial obj = new StringTrial()
	obj.Display();
	}
} 