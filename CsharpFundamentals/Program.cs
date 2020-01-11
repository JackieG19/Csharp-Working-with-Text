using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using statement*/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedani";
            Console.WriteLine("ToUpper: {0}", fullName.Trim().ToUpper());            
            /*ToUpper() Method - converts every characters to uppercase*/
        }
    }
}
