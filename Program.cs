using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guoyang_Liu_Sec003_Lab01
{
    public delegate string SmallestString(string playerName);
    class Program
    {
           
        static void Main(string[] args)
        {
            // create an instance of the delegate 
            Func<string, string, string, string> func = Minimum;
            // call Minimum using 3 delegate variables
            Console.WriteLine($"The smallest string is {func("Giannis Antetokounmpo", "Kawhi Leonard", "Ming Yao")}");

            // create an instance of the delegate 
            Action<double, double, double> action = AvgGrade;
            // call AvgGrade using 3 delegate variables
            action(99.99, 88.88, 77.77);


        } // end main method

        private static string Minimum(string string1, string string2, string string3)
        {
            string result = string1;
            if (string.Compare(string1, string2, true) == 1)
            {
                result = string2;
            }

            else if (string.Compare(result, string3, true) == 1)
            {
                result = string3;

            }
            return result;
        }//end the filterString method

        private static void AvgGrade(double value1, double value2, double value3)
        {
            double result = (value1 + value2 + value3) / 3;
            Console.WriteLine($"The average of grades is {result}");

        }// end AvgGrade method


    }// end class

}// end namespace
            
    
            
          
    
           
         
           

        


    

       



