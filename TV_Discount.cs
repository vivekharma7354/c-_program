using System;
namespace Discount
{
	class Func
	{
		static int Main()
		{
		int x,y,d;
		Console.WriteLine("\t\t\t###Program For Calculation Of Discount Percentage On Different Type Of TV\'s###\n\t\t\t\t\t\t\tBy Vivek Sharma\n\n\n");
		Console.WriteLine("Here , Is A List Of Differnt Type Of TV\'s To Choose from : ");
		Console.WriteLine("\n\n\t1.LCD");
		Console.WriteLine("\n\n\t2.LED");
		Console.WriteLine("\n\nPlease Select One : ");
		x=int.Parse(Console.ReadLine());
		Console.WriteLine("\n\nHere , Is A List Of Differnt Sizes Of TV\'s To Choose from : ");
		Console.WriteLine("\n\n\t1.32 Inches");
		Console.WriteLine("\n\n\t2.Less Than 32 Inches");
		Console.WriteLine("\n\nPlease Select One : ");
		y=int.Parse(Console.ReadLine());
		if((x==1) && (y==1))
		{
			d=10;
		}
		else if((x==2) && (y==1))
		{
			d=15;
		}
		else if((x==1) && (y==2))
		{
			d=8;
		}
		else
		{
			d=12;
		}
		Console.WriteLine("\n\n\t\t---Congratultions You Have Got {0}% Discount---",d);
		Console.ReadKey();
		return 0;
		}
	}
}	
