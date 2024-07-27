class Cloth
{
    public static void Main(string[] args)
    {
        float amt, milk_d, hand_d, bill;
        Console.WriteLine("Enter the amount:");
        amt = float.Parse(Console.ReadLine());
	switch (amt)
        {
            case bool _ when amt > 0 && amt < 100:
                milk_d = 0.0F;
                hand_d = 5.0F;
                break;

            case bool _ when amt >= 100 && amt < 200:
                milk_d = 5.0F;
                hand_d = 7.5F;
                break;

            case bool _ when amt >= 200 && amt < 300:
                milk_d = 7.5F;
                hand_d = 10.0F;
                break;

            case bool _ when amt >= 300:
                milk_d = 10.0F;
                hand_d = 15.0F;
                break;

            default:
                milk_d = 0.0F;
                hand_d = 0.0F; // Default values when amt is not within specified ranges
                break;
        }

        bill = amt - (amt * milk_d / 100);
        bill = amt - (amt * hand_d / 100);

        Console.WriteLine("Bill: {bill}");
	}
}
