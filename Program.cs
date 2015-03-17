using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestPractices.Example_Features;

namespace BestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine(x.Multiply(3)); //LINQ is composed entirely of extension methods like these.
            //LINQ operators are extension methods on IEnumerable<T>.

            //Example anonymous type
            // - Compiler gives a default implementation by overriding the virtual members of System.Object.
            var person = new //implicitly typed object initialiser
            {
                FirstName = "John",
                LastName = "Doe"
            };
            Console.WriteLine(person.GetType().Name);
        }
    }
}
