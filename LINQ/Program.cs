using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {


       
       


        static void Main(string[] args)
        {    
          List<string> myCities = new List<string>() { "Daytona","Ocala","Orlando","Tampa" ,"Gainsville", };


            //sampleList = sampleList.OrderBy(s => s.Length).ToList();

            myCities = myCities.OrderBy(s => s.Length).ToList();

           foreach(var item in myCities)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
