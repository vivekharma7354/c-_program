using System;
namespace tax
{
  class Func
  { static int Main()
    {
    	int bps;
    	double ta,da,hra,gs,tax,ns;
    	Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t ***Program For Calculation of Gross Salary , Net Salary And Tax***\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\t\t\t By Vivek Sharma\n\n\n");
    	Console.WriteLine("Enter Basic Pay Salary:");
    	bps=int.Parse(Console.ReadLine());
    	ta=0.05*bps;
    	da=0.075*bps;
    	hra=0.11*bps;
    	gs=bps+ta+da+hra;
    	tax=0.15*gs;
    	ns=gs-tax;
    	Console.WriteLine("\n T.A.  =  5% of Basic Pay Scale : {0}\n",ta);
    	Console.WriteLine("\n D.A.  =  7.5% of Basic Pay Scale : {0}\n",da);
    	Console.WriteLine("\n H.R.A.  =  11% of Basic Pay Scale : {0}\n",hra);
    	Console.WriteLine("\n Gross Salary  =  Basic + T.A. + D.A. + H.R.A. :{0}\n",gs);
    	Console.WriteLine("\n Tax  =  15% of Gross Salary : {0}\n",tax);
    	Console.WriteLine("\n Net Salary  =  Gross Salary - Tax : {0}\n",ns);
    	Console.ReadKey();
    	return 0;
    	}
  }
}  