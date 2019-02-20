using System;
namespace Comparer
{
	class Func
		{
			static int Main()
				{
				int v1,v2,v3,v4;
				Console.WriteLine("\t\t\t###Program For Comparision Of 4 Different numbers###\n\t\t\t\t\t\tBy Vivek Sharma\n\n\n");
				Console.WriteLine("Please Enter Your First Number : ");
				v1=int.Parse(Console.ReadLine());
				Console.WriteLine("\n\nPlease Enter Your Second Number : ");
				v2=int.Parse(Console.ReadLine());
				Console.WriteLine("\n\nPlease Enter Your Third Number : ");
				v3=int.Parse(Console.ReadLine());
				Console.WriteLine("\n\nPlease Enter Your Fourth Number : ");
				v4=int.Parse(Console.ReadLine());
				if((v1>v2) && (v1>v3) && (v1>v4))
				{
					Console.WriteLine("\n\nFrom The Given Numbers First Number Is The Greatest Number.....");
				}
				else if((v1<v2) && (v2>v3) && (v2>v4))
				{
					Console.WriteLine("\n\nFrom The Given Numbers Second Number Is The Greatest Number.....");
				}
				else if((v3>v2) && (v1<v3) && (v3>v4))
				{
					Console.WriteLine("\n\nFrom The Given Numbers Third Number Is The Greatest Number.....");
				}
				else if((v4>v2) && (v4>v3) && (v1<v4))
				{
					Console.WriteLine("\n\nFrom The Given Numbers Fourth Number Is The Greatest Number.....");
				}
				else if((v1==v2) && (v1==v3) && (v1==v4))
				{
					Console.WriteLine("\n\nAll The Given Number Are Equal.....");
				}
				else
				{
					Console.WriteLine("Sorry , Can\'t Find A Suitable Criterion For These Numbers.....");
				}
					Console.WriteLine("\n\n\n\n\n\n\t\t\t\t***Thank You For Using The Program***");
				Console.ReadKey();
				return 0;
				}
		}
	}