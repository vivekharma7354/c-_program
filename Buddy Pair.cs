using System;
namespace BuddyApplication
{
  class Func
	{
	 static int Main()
		{
			int x,y,m,sum=0,sum1=0;
			Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t ***Program For Checking If The Given Pair Of Numbers Is A Buddy Pair Or Not***\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t\t \t By Vivek Sharma\n\n\n");
			Console.WriteLine("Please Enter The First Number OF Pair Of Numbers To Check If It Is A Buddy Pair : ");
			x=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please Enter The Second Number OF Pair Of Numbers To Check If It Is A Buddy Pair : ");
			y=Convert.ToInt32(Console.ReadLine());
			for(m=1;m<=y/2;m++)
			{
				if(y%m==0)
				{
					sum+=m;
				}
			}
			for(m=1;m<=x/2;m++)
			{
				if(x%m==0)
				{
					sum1+=m;
				}
			}
			if((sum1==y) && (sum==x))
			{
				Console.WriteLine("\n\n\t\t\t\t--------The Given Pair Is A Buddy Pair.-----------");
			}
			else
			{
				Console.WriteLine("\n\n\t\t\t--------The Given Number Is Not A Buddy Pair.----------");
			}
			Console.ReadKey();
			return 0;
		}
	}	
}