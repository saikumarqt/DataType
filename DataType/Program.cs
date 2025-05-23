using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comments:
            //Variables are used to store data or information based on the data type.
            /*
             * ex: int a=10;
             * int is  a data type where a is a varibale
             * and value is 10.
             * 
             * Data types: Data types of values and reference types:
             *  Value types: are nothing but storing the values they have range and size.
             *  1)Integer types
             *  2)Floating types:
             *  3)Character types
             *  4)Boolean types
             *  
             *  Reference types:where is storing based on the address.
             *  1)string
             *  2)object
             *  
             *  1)Integer types: these data type store data with out decimals.
             *  Singed types:data will be in the form of both postive and negative values.
             *  short 
             *  int 
             *  long
             *  
             *  Unsigned types:which holds only postive values.
             *  
             *  ushort 
             *  uint
             *  ulong 
             *  
             */
            //programm to display short int min,max and range
            short a = 32767;
            Console.WriteLine("value of a is {0}", a);
            Console.WriteLine("short minimum value is {0}", short.MinValue);//-32768
            Console.WriteLine("short maximum value is {0} ", short.MaxValue);//32767
            Console.WriteLine("unsigned short  min value is {0}", ushort.MinValue);//0
            Console.WriteLine("unsigned short max value is  {0}", ushort.MaxValue);//65535
            Console.WriteLine("size of short is {0}bytes", sizeof(short));
            Console.WriteLine("base type of short is  {0}", a.GetType());
        }
    }
}
