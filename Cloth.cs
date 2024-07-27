class Cloth
{																								
	public static void Main(string[] args)
	{
	float amt,milk_d,hand_d,bill;
	System.Console.WriteLine("Enter the amount");
	
	Switch(amt) {
	case1: if(amt<100 && amt>0) {
	milk_d=0.F;
	hand_d=5.0F;
	} 
	
	case2: if(amt<200 && amt>100)
	{
	milk_d=5.0F;
	hand_d=7.5F;
	} 
	
	case3: if(amt<300 && amt>200)
	{
	milk_d=7.5F;
	hand_d=10F;
	} 
	
	case4: if(amt>300)
	{
	milk_d=10F;
	hand_d=15F;
	}
 	
	bill=amt-(amt*milk_d/100);
	bill=amt-(amt*hand_d/100);
                	
}}		      
	