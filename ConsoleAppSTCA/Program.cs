using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSTCA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "Jigar"; // Value type

            object obj = 10; // Boxing // Referece

            //int i = (int)obj; // unboxing


            //int i = 4;
            //switch (i)
            //{
            //    case 0:
            //        Console.Write("This is 0 value");
            //        break;
            //    case 4:
            //        break
            //    case 5:
            //        Console.Write("This is 0 value");
            //        break;

            //    case 6:
            //        Console.Write("This is 0 value");
            //        break;
            //        //default:
            //        //    Console.Write("This is 0 value");
            //}

            //for (int i = 0; i < length; i++)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}

            //
            //if (str == "Jigar" && str == "Avinas" && str == "Sandip")
            //{
            //    // 
            //}

            //else if (str == "Gagan") 
            //{ 

            //}
            //else if (str == "Twinkal")
            //{

            //}

            //else
            //{

            //}


            //F1(true);

            // Interview
            float f = 2.5656251251252125125F; // Float
            double d = 2.5656565656565666556D; // Float

            bool _bool = true;
            char c = 'B'; // Single inv comma
            string s = "fsakjdfhf"; // Single inv comma
            string s1 = "adsad"; // Single inv comma

            //Console.WriteLine(a);
            //Console.WriteLine("</br>");
            //Console.WriteLine(a);
            Console.WriteLine("</br>");
            Console.WriteLine(f);
            Console.WriteLine("</br>");
            Console.WriteLine(d);
            Console.WriteLine("</br>");
            Console.WriteLine(_bool);
            Console.WriteLine("</br>");
            Console.WriteLine((int)c);
            Console.WriteLine("</br>");
            Console.WriteLine(s);

            var a = s == s1; // true /false

            // Logical operators
            // &&   =  AND
            // ||   = OR
            // !   = NOT

            //1 = true;
            //0 = FALSE;

            //1 && 1 && 1 = 1 
            //0 && 1 && 0 = 0
            //1 && 0 && 1 = 0
            //0 && 0 && 1 = 0


            //1 || 1= 1
            //0 || 1= 1
            //1 || 0= 1
            //0 || 0= 0

            //!(1 || 1) = 0
            //!(0 || 1) = 0
            //!(1 || 0) = 0
            //!(0 || 0) = 1



            // ==, !=, >, <, >=, <=
            // == and ===



            //decimal decimal123 = 2.021521;


            // Type casting : 

            // 1.  implicit type casting // Smaller Datatypes to bigger datatypes
            //  2. Explicit type casting // Bigger Datatypes to Smaller datatypes

            //int a = 20; // temp store // 4 bytes
            long b = 30; // 8 bytes

            double double123; // break

            double? double1234 = 44; // Non- nullable


            //double myDouble = a; /// implicit type casting


            //int myDouble123 = Convert.ToInt32(double123); // Handle null value /// Explicit type casting

            //int myDouble = (int)double123; //Code break  /// Explicit type casting




            string abc = null;
            string str = (string)abc;

            string str111 = Convert.ToString(abc);

            //Console.ReadLine();






            Console.WriteLine(10);


            //a = 120; // temp store
            Console.WriteLine(120);


            var tempvar = 1.5; //Supar datatype

            int y = 10;




            //int l = y + v;
            //1. Arith +,-,/,*,
            int v = 10;

            //v++; // Post increment 
            //++v; // Pre increment

            //v = v - 2;

            Console.WriteLine("V value : " + ++v);
            Console.WriteLine("</br>");
            Console.WriteLine(v);

            //Console.WriteLine("V value : " + --v);

            Console.ReadLine();

            //v--; // Post Decrement
            //--v; // pre Decrement





            //2. Logical
            //    3. Comparis
            //    4. assignment
            //    5 Bitware // True or false

        }

        public static void F1(object a)
        {

        }

    }
}
