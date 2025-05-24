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
            short a = 500;
            Console.WriteLine("value of a is {0}", a);
            Console.WriteLine("short minimum value is {0}", short.MinValue);//-32768
            Console.WriteLine("short maximum value is {0} ", short.MaxValue);//32767
            Console.WriteLine("unsigned short  min value is {0}", ushort.MinValue);//0
            Console.WriteLine("unsigned short max value is  {0}", ushort.MaxValue);//65535
            Console.WriteLine("size of short is {0}bytes", sizeof(short));
            Console.WriteLine("base type of short is  {0}", a.GetType());

            //varibale once declared cannot be used rather we can create a new one
            //varibales are of 3 types.
            /*
             * 1)local varible
             * 2)instance varible
             * 3)static varible
             * 
             * local varible:
             * local varible is used to call when ever needed with in the method or a function so
             * the scope of the varible is to that block or function.
             * local varibles should be initialized with some value or assign some value.
             */
            int b=2147483647;
            Console.WriteLine(b);
            Console.WriteLine("int minimum value is {0}",int.MinValue);//-2147483648
            Console.WriteLine("int maximum value is {0}",int.MaxValue);// 2147483647
            Console.WriteLine("unsigned int minimum value is {0}",uint.MinValue);//0
            Console.WriteLine("unsigned int maximum value is {0}",uint.MaxValue);// 4294967295
            Console.WriteLine("size of int is {0} bytes",sizeof(int));//4 bytes
            Console.WriteLine("base type of int is {0}", b.GetType());

            long c = 214748364845465465;
            Console.WriteLine(c);
            Console.WriteLine("long minimum value is {0}", long.MinValue);//-9223372036854775808
            Console.WriteLine("long maximum value is {0}",long.MaxValue);//  9223372036854775807
            Console.WriteLine("unsigned long minimum value is {0}",ulong.MinValue);//0
            Console.WriteLine("unsigned long maximum value is {0}",ulong.MaxValue);//184467441073709551615
            Console.WriteLine("size of long is {0} bytes", sizeof(long));//8
            Console.WriteLine("base type of long is {0}", c.GetType());


        }
    }
}
