class Depreciate 
{ 
	public static void Main(string[] args) 
 	{ 
 	float depreciation, PurchasePrice, Yrs, SalvageValue; 
 	string d,p,y; 
	System.Console.Write("Enter the Depreciation : "); 
 	d = System.Convert.ToString(args[0]); 
 	depreciation = float.Parse(d); 
 	System.Console.Write("Enter the PurchasePrice : "); 
 	p = System.Convert.ToInt32(args[0]); 
 	PurchasePrice = float.Parse(p); 
 	System.Console.Write("Enter the Amount of Years : "); 
 	y = System.Convert.ToInt32(args[0]); 
 	Yrs = float.Parse(y); 
 	SalvageValue = (float)(PurchasePrice - (depreciation * Yrs)); 
 	System.Console.WriteLine("SalvageValue = " + SalvageValue); 
 	} 
}               