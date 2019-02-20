using System;
namespace Percentage
	{
	class Func
		{
		static int Main()
			{
				int s1=0,s2=0,s3=0,s4=0,s5=0,sum=0;
				Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t ###Program To Calculate the sum of Marks of a Student & It\'s Percentage###\n\t\t\t\t\t\t\tBy Vivek Sharma\n\n\n");
				Console.WriteLine(" \nEnter Your Physics Marks : ");
				s1=int.Parse(Console.ReadLine());
				Console.WriteLine(" \nEnter Your Chemistry Marks : ");
				s2=int.Parse(Console.ReadLine());
				Console.WriteLine(" \nEnter Your Maths Marks : ");
				s3=int.Parse(Console.ReadLine());
				Console.WriteLine(" \nEnter Your English Marks : ");
				s4=int.Parse(Console.ReadLine());
				Console.WriteLine(" \nEnter Your P.H.E. Marks : ");
				s5=int.Parse(Console.ReadLine());
				sum=s1+s2+s3+s4+s5;
				Console.WriteLine("\n\nSum Of the Marks Of The Student is : {0}",sum);
				Console.WriteLine("\n\nNow Finding The Percentage ..........................");
				Console.WriteLine("\n\nPercentage Of The Student Is : {0}",(float)sum/5);
				Console.ReadKey();
				return 0;
			} 
		}	
	}	