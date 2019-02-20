using System;
namespace CalendarApplication
{
	class Calendar
	{
		static 
		int Main()
		{
			long d,m,y,days,wd;
			Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t ***Program For Calculation of Sum Of Marks & The Student\'s Percentage '***\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t\t By Vivek Sharma\n\n\n");
			Console.WriteLine("\n Please Enter The Date : ");
			d=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n Please Enter The Month : ");
			m=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n Please Enter The Year : ");
			y=Convert.ToInt32(Console.ReadLine());
			days=(y-1900)*365+(y-1900)/4;
			switch(m)
    {
    	case 1: days+=d;break;
    	case 2: days+=d+31;break;
    	case 3: days+=d+31+28;break;
    	case 4: days+=d+31+28+31;break;
    	case 5: days+=d+31+28+31+30;break;
    	case 6: days+=d+31+28+31+30+31;break;
    	case 7: days+=d+31+28+31+30+31+30;break;
    	case 8: days+=d+31+28+31+30+31+30+31;break;
    	case 9: days+=d+31+28+31+30+31+30+31+31;break;
    	case 10: days+=d+31+28+31+30+31+30+31+31+30;break;
    	case 11: days+=d+31+28+31+30+31+30+31+31+30+31;break;
    	case 12: days+=d+31+28+31+30+31+30+31+31+30+31+30;break;
	}
	if(((y%400==0)||(y%4==0&&y%100!=0)) && m<=2)
		days-=1;
	wd=days%7;
		switch(wd)
		{
			case 0:Console.WriteLine("\n==> The Day On Your given Date Is Found To be Sunday");break;
			case 1:Console.WriteLine("\n==> The Day On Your given Date Is Found To be  Monday");break;
			case 2:Console.WriteLine("\n==> The Day On Your given Date Is Found To be  Tuesday");break;
			case 3:Console.WriteLine("\n==> The Day On Your given Date Is Found To be  Wednesday");break;
			case 4:Console.WriteLine("\n==> The Day On Your given Date Is Found To be  Thursday");break;
			case 5:Console.WriteLine("\n==> The Day On Your given Date Is Found To be  Friday");break;
			case 6:Console.WriteLine("\n==> The Day On Your given Date Is Found To be  Saturday");break;
		}
		Console.ReadLine();
		return 0;
}
}
}