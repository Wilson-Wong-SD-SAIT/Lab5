using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() 
        {
            Console.WriteLine("InvalidRadiusException: Radius less than 0");
        }
        public InvalidRadiusException(double radius) 
        {
            Console.WriteLine("InvalidRadiusException: Radius (" + radius + ") is not valid");
        }
    }
}
