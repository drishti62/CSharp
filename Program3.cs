using System;

class Program3
{
    public static void Main(string[] args)
    {
       
        for (int i = 1; i <= 5; i++)
        {
            
            for (int j = 1; j <= 5; j++)
            {
                
                if (i == j)
                {
                    System.Console.WriteLine("{i}*{j} "); 
                }
                else
                {
                    System.Console.WriteLine(" $ ");  
                }
            }
            
        }
    }
}
