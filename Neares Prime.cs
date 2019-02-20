using System;
namespace Prime
{
	class Nearest_Prime
	{
		static int Main()
		{
			int x,y,sum=0,count,n=0,m=0,r;
	Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t ***Program For Finding Nearest Prime Numbers(\'s) Of A Given Number***\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t\t \t By Vivek Sharma\n\n\n");
	Console.WriteLine("Please Enter The Number To find Its\'s Nearest Prime Number(\'s) : ");
	y = Convert.ToInt32(Console.ReadLine());
	r=y;
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
			n = y;	
			count++;
		}
		if(count==1)
		break;
	}
	for(y=y-1,count=0;;y--)
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
			count++;
			m = y ;
		}
		if(count==1)
			break;		
	}
	if(r-m>n-r)
	{
		Console.WriteLine("\n\nThe Number \"{0}\" Is The Nearest Prime Number To The Given Number \"{1}\"." , m , r );
	}
	else if(n-r>r-m)
	{
		Console.WriteLine("\n\nThe Number \"{0}\" Is The Nearest Prime Number To The Given Number \"{1}\".",n,r);
	}
	else
	{
		Console.WriteLine("\n\nThe Numbers \"{0}\" & \"{1}\" Are The Nearest Prime Numbers To The Given Number \"{2}\".",m,n,r);
	}
	Console.ReadLine();
	return 0;
}
}
}