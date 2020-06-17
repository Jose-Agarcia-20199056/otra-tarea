using System;
					
public class Program
{
	public static void Main()
	{
		Random ale = new Random();
		int num;
		
		
		num = ale.Next(50,100);
		Console.WriteLine("Su numero aleatorio entre 50 y 100 es " +num);
		
		
		
		if(num >= 50){
			
		Console.WriteLine("Desea generar otro numero ");
	     string afi = Console.ReadLine();
			
			if(afi== "si"){
				
				num = ale.Next(50,100);
		   Console.WriteLine("Su segundo numero aleatorio entre 50 y 100 es " +num);
		    
				
			}	
			
			 else if(afi== " no") {
				 
				 
				
			
					
				
				}
				
			}
			




		

	}
}