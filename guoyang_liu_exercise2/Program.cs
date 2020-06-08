using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guoyang_liu_exercise2
{
    class Program
    {
        // delegate for a function that receives an int and returns a bool
        public delegate bool GradesPredicate(double grade);

        static void Main(string[] args)
        {
            double[] grades = { 11.11, 22.22, 33.33, 44.44, 55.55, 66.66, 77.77, 88.88, 99.99, 50.00 };

            GradesPredicate fiftyPredicate =  grade => grade >= 50;

            GradesFilter(grades, fiftyPredicate );
        }

        private static void GradesFilter(double[] doubleArray, GradesPredicate predicate)
        {
            // hold the selected elements
            var result = new List<double>();

            // iterate over each element in the array
            foreach (var item in doubleArray)
            {
                // if the element satisfies the predicate
                if (predicate(item))
                {
                    result.Add(item); // add the element to the result
                }
            }

            Console.WriteLine($"Here are those grades values which are greater than or equal to 50:");
            // iterate over each element in the List
            foreach (double item in result)
            {
                Console.WriteLine($"{item:f2} "); // print item followed by a space
            }

            Console.WriteLine(); // add a new line


        }

    }
}
