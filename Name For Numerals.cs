using System;
namespace Name
{
	class Func
		{
		static int Main()
			{
				int a,t,u;
				Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t ***Program for getting name of numerals '***\n\n\n");
				Console.WriteLine("\n\nEnter a number from 0-99 :");
				a=int.Parse(Console.ReadLine());
				t=a/10;
				u=a%10;
				switch(t)
				{
					case 2: Console.WriteLine(" Twenty ");break;
					case 3: Console.WriteLine(" Thirty ");break;
					case 4: Console.WriteLine(" Forty ");break;
					case 5: Console.WriteLine(" Fifty ");break;
					case 6: Console.WriteLine(" Sixty ");break;
					case 7: Console.WriteLine(" Seventy ");break;
					case 8: Console.WriteLine(" Eighty ");break;
					case 9: Console.WriteLine(" Ninety ");break;
					case 1: 
						switch(u)
						{
							case 0: Console.WriteLine("Ten");break;
							case 1: Console.WriteLine("Eleven");break;
							case 2: Console.WriteLine("Twelve");break;
							case 3: Console.WriteLine("Thirteen");break;
							case 4: Console.WriteLine("Fourteen");break;
							case 5: Console.WriteLine("Fifteen");break;
							case 6: Console.WriteLine("Sixteen");break;
							case 7: Console.WriteLine("Seventeen");break;
							case 8: Console.WriteLine("Eighteen");break;
							case 9: Console.WriteLine("Nineteen");break;
						}break;
					
				}
				if(a!=1)
				{
					switch(u)
					{
						case 1: Console.WriteLine("One"); break;
						case 2: Console.WriteLine("Two"); break;
						case 3: Console.WriteLine("Three"); break;
						case 4: Console.WriteLine("Four"); break;
						case 5: Console.WriteLine("Five"); break;
						case 6: Console.WriteLine("Six"); break;
						case 7: Console.WriteLine("Seven"); break;
						case 8: Console.WriteLine("Eight"); break;
						case 9: Console.WriteLine("Nine"); break;
					}
				}
				if(a==0)
				Console.WriteLine("Zero");
				Console.ReadKey();
				return 0;
			}
				
		}
	}