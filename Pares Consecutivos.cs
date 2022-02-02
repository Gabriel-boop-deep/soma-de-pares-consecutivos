using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
        	int a=-1;
        	while (a!=0)
        	{
        	    a=int.Parse(Console.ReadLine());
        	    int i=a;
        	    int count=0;
        	    int sum=0;
        	    string str="";
        	    while(str!=null && a!=0)
        	    {
        	    	i=i+1;
        	    	if (i%2==0)
        	    	{
        	    		sum=sum+i;
        	    		count=count+1;
        	    		//Console.WriteLine(i);
        	    	}
        	  
        	    	if (a%2==0 && count==4 )
        	    	{
        	    		Console.WriteLine(sum+a);
        	    		break;
        	    	}
        	    	if (a%2!=0 && count==5)
        	    	{
        	    		Console.WriteLine(sum);
        	    		break;
        	    		
        	    	}
        	    }
          	}
        }
    }
}
