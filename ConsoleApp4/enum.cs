using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject
{
    class Program
    {
        public enum department
        {
            physics = 10,
            chemistry,
            mathematics = 15,
            biology = 18,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("department of mathematics:{0}", (int)department.mathematics);
            Console.ReadKey();

            
            

        }
    }
    
}
