using System;
namespace NewApplication
{
	class Workinge
	{
		static int Main()
		{
			int x,y,sum=0,count;
			Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t ***Program For Finding Ten Upcoming Prime Numbers ***\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t\t \t By Vivek Sharma\n\n\n");
			Console.WriteLine("Please Enter The Number To find 10 Prime Numbers Next To It : ");
			y=int.Parse(Console.ReadLine());
			for(y=y+1,count=0;;y++)
			{
				sum=0;
				for(x=1;x<=y/2;x++)
				{
					if(y%x==0)
					{
						sum+=x;
					}
				}
				if(sum==1)
				{
					Console.WriteLine("\n\nThe Number ({0}) Is A Prime Number",y);	
					count++;
				}
				if(count==10)
					break;
			}
			
			Console.ReadKey();
			return 0;
		}
	}
}