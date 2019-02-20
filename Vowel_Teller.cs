using System;
namespace Vowel
{
	class Func
	{
		static int Main()
		{
			char ch;
			Console.WriteLine("\t\t\t###Program To Determine If A Letter Is Either A Consonant Or A Vowel###\n\n\n\n\n");
			Console.WriteLine("Please , Enter The Alphabet About Which You Want To Check Information : ");
			ch=Convert.ToChar(Console.ReadLine());
			switch(ch)
			{
				case'a':
				case'A':Console.WriteLine("\n\n\t\t\t----------The Inputed Letter Is A Vowel--------------");
				break;	
				case'e':
				case'E':Console.WriteLine("\n\n\t\t\t----------The Inputed Letter Is A Vowel--------------");
				break;
				case'i':
				case'I':Console.WriteLine("\n\n\t\t\t----------The Inputed Letter Is A Vowel--------------");
				break;
				case'o':
				case'O':Console.WriteLine("\n\n\t\t\t----------The Inputed Letter Is A Vowel--------------");
				break;
				case'u':
				case'U':Console.WriteLine("\n\n\t\t\t----------The Inputed Letter Is A Vowel--------------");
				break;
				default:Console.WriteLine("\n\n\t\t\t----------The Inputed Letter Is A Consonant------------");
				break;
			}
			Console.ReadKey();
			return 0;
		}
	}
}	
