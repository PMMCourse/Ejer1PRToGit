using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseRelations
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld(5);
        }

        public static void HelloWorld<TType>(TType type)
        {
            Console.WriteLine($"Hello {type.ToString()}");
        }
    }

    
}
