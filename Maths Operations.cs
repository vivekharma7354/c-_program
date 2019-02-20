using System;
namespace OperationApplication
{
	class Func
	{
		static int Main()
		{
		int op;
		float x,y,res;
			Console.WriteLine("\t\t\t###Program For Different Mathematical Operations On Different numbers###\n\t\t\t\t\t\t\tBy Vivek Sharma\n\n\n");
			Console.WriteLine("Please Enter Your First Number : ");
			x=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n\nPlease Enter Your First Number : ");
			y=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n\n1.Addition");
			Console.WriteLine("\n2.Subtraction");
			Console.WriteLine("\n3.Multiplication");
			Console.WriteLine("\n4.Division");
			Console.WriteLine("\n\nPlease Choose An Mathematical Operation From The List Given Above : ");	
			op=Convert.ToInt32(Console.ReadLine());
			if(op==1)
			{
				res=x+y;
			}
			else if(op==2)
			{
				res=x-y;
			}
			else if(op==3)
			{
				res=x*y;
			}
			else
			{
				res=x/y;
			}
			Console.WriteLine("\n\nYour Result Is : {0}",res);
			Console.WriteLine("\n\n\n\n\n\n\t\t\t\t***Thank You For Using The Program***");
			Console.ReadKey();
			return 0;
			}
	}
}