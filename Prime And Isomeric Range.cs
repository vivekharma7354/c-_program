using System;
namespace IsomericApplication
{
	class Func
	{
		static int Main()
		{
			int x,y,m,sum;
			Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t *** Program For Finding Prime And Isomeric Numbers In A Given Range ***\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t\t \t By Vivek Sharma\n\n\n");
			Console.WriteLine("Please Enter The Upper Limit Of Range In Which You Want To Find The Prime And Isomeric Numbers : ");
			y=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please Enter The Lower Limit Of Range In Which You Want To Find The Prime And Isomeric Numbers : ");
			x=Convert.ToInt32(Console.ReadLine());
			for(;x<=y;x++)
			{   sum=0;
				for(m=1;m<=x/2;m++)
				{
					if(x%m==0)
					{
						sum+=m;
					}
				}
			if(sum==x)
					{
						Console.WriteLine("\n\nIn The Range,The Number ({0}) Is Isomeric.",x);
					}
			else if(sum==1)
			{
				Console.WriteLine("\n\nIn The Range,The Number ({0}) Is Prime.",x);
			}
			}
			Console.ReadKey();
			return 0;
		}
	}
}	