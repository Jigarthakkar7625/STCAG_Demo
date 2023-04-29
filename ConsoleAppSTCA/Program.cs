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
            int a = 10;

            string temp = "Jigar";

            string temp1 = "1234567890"; // 8 Charactor

            string result = temp + temp1;
            string result1 = String.Concat(temp, temp1);


            string result123 = "This is " + a + "Hello";
            string result1234 = $"This is {a} Hello"; // String interpolation


            var IndexOf = temp.IndexOf("g");


            var LastIndexOf = temp.LastIndexOf("g");

            var PadLeft = temp1.PadRight(8, '0');

            var substring = temp1.Substring(2, 6);

            //var replace = temp.Replace("ga", "Thakkar");


            var compare = String.Compare(temp, temp1);

            if (String.IsNullOrEmpty(temp)) // NULL, ""
            {

            }

            //if ()
            //{

            //}

            string[] strings = temp1.Split('#');




            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            //Console.WriteLine(temp[10]);






            //// Call by value with Value type
            //// Call by value with reference type

            //// Call by refrence with Value type
            //// Call by refrence with reference type

            //Employee employee = new Employee(); // Referece type
            //employee.Name = "JIgar";

            //int a = 10; // Value type

            //FunctionTest(a);

            ////Console.WriteLine(a);

            ////FunctionTest(employee);

            ////Console.WriteLine(employee.Name);



            /////Call by referece
            //FunctionTestReferece(ref a);
            //Console.WriteLine(a);

            //FunctionTestReferece(ref employee);
            //Console.WriteLine(employee.Name);

            //// Break
            //// Continue
            //// Go to
            //int Temp = 10;
            //for (int i = 0; i < Temp; i++)
            //{
            //    if (i == 8)
            //    {
            //        //goto MyGotoStatement;
            //    }

            //    Console.WriteLine("Next statement" + i);
            //}
            ////goto MyGotoStatement;

            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");
            ////    Console.WriteLine("Out of For statement");



            ////MyGotoStatement:
            ////    Console.WriteLine("MyGotoStatement Called!!!");


            ////var MyValue = Math.Sqrt(144);

            //// In build 
            //// User define functions

            //Console.WriteLine("Agter MyGotoStatement Called!!!");
            ////int Temp = 10;
            ////for (int i = 0; i < stringTemp.lenght; i++)
            ////{

            ////    Console.WriteLine(sreing[i]);
            ////}

            //string[] stringTemp = new string[] { "a", "b", "c", "d" };

            ////int index = 0;
            ////foreach (var item in stringTemp)
            ////{

            ////    Console.WriteLine(index);
            ////    Console.WriteLine(item);
            ////    index++;
            ////}



            ////int index = 10;
            ////while (index < 20) /// If condition true then it will go inside
            ////{
            ////    Console.WriteLine(stringTemp[index++]);
            ////    index++;
            ////}


            ////do  /// atleast 1 time this will execute
            ////{
            ////    Console.WriteLine(stringTemp[index++]);
            ////    index++;
            ////}
            ////while (index < 20);




            //// For
            //// While
            //// Do while
            //// For each

            ////int a = 10;

            //// Ternary operator.
            ////var result = (a == 10) ? "TRUE" : "FALSE";

            ////if (a == 10)
            ////{
            ////    var temp1  = a + a;
            ////    var temp1 = a + a;
            ////    Console.WriteLine("TRUE");
            ////    Console.WriteLine("TRUE");
            ////    Console.WriteLine("TRUE");
            ////    Console.WriteLine("TRUE");
            ////}
            ////else 
            ////{
            ////    Console.WriteLine("FALSE");
            ////}


            //string str = "Jigar"; // Value type

            //object obj = 10; // Boxing // Referece

            ////int i = (int)obj; // unboxing


            ////int i = 4;
            ////switch (i)
            ////{
            ////    case 0:
            ////        Console.Write("This is 0 value");
            ////        break;
            ////    case 4:
            ////        break
            ////    case 5:
            ////        Console.Write("This is 0 value");
            ////        break;

            ////    case 6:
            ////        Console.Write("This is 0 value");
            ////        break;
            ////        //default:
            ////        //    Console.Write("This is 0 value");
            ////}

            ////for (int i = 0; i < length; i++)
            ////{

            ////}

            ////foreach (var item in collection)
            ////{

            ////}

            ////
            ////if (str == "Jigar" && str == "Avinas" && str == "Sandip")
            ////{
            ////    // 
            ////}

            ////else if (str == "Gagan") 
            ////{ 

            ////}
            ////else if (str == "Twinkal")
            ////{

            ////}

            ////else
            ////{

            ////}


            ////F1(true);

            //// Interview
            //float f = 2.5656251251252125125F; // Float
            //double d = 2.5656565656565666556D; // Float

            //bool _bool = true;
            //char c = 'B'; // Single inv comma
            //string s = "fsakjdfhf"; // Single inv comma
            //string s1 = "adsad"; // Single inv comma

            ////Console.WriteLine(a);
            ////Console.WriteLine("</br>");
            ////Console.WriteLine(a);
            //Console.WriteLine("</br>");
            //Console.WriteLine(f);
            //Console.WriteLine("</br>");
            //Console.WriteLine(d);
            //Console.WriteLine("</br>");
            //Console.WriteLine(_bool);
            //Console.WriteLine("</br>");
            //Console.WriteLine((int)c);
            //Console.WriteLine("</br>");
            //Console.WriteLine(s);

            //var a = s == s1; // true /false

            //// Logical operators
            //// &&   =  AND
            //// ||   = OR
            //// !   = NOT

            ////1 = true;
            ////0 = FALSE;

            ////1 && 1 && 1 = 1 
            ////0 && 1 && 0 = 0
            ////1 && 0 && 1 = 0
            ////0 && 0 && 1 = 0


            ////1 || 1= 1
            ////0 || 1= 1
            ////1 || 0= 1
            ////0 || 0= 0

            ////!(1 || 1) = 0
            ////!(0 || 1) = 0
            ////!(1 || 0) = 0
            ////!(0 || 0) = 1



            //// ==, !=, >, <, >=, <=
            //// == and ===



            ////decimal decimal123 = 2.021521;


            //// Type casting : 

            //// 1.  implicit type casting // Smaller Datatypes to bigger datatypes
            ////  2. Explicit type casting // Bigger Datatypes to Smaller datatypes

            ////int a = 20; // temp store // 4 bytes
            //long b = 30; // 8 bytes

            //double double123; // break

            //double? double1234 = 44; // Non- nullable


            ////double myDouble = a; /// implicit type casting


            ////int myDouble123 = Convert.ToInt32(double123); // Handle null value /// Explicit type casting

            ////int myDouble = (int)double123; //Code break  /// Explicit type casting




            ////string abc = null;
            ////string str = (string)abc;

            ////string str111 = Convert.ToString(abc);

            ////Console.ReadLine();






            //Console.WriteLine(10);


            ////a = 120; // temp store
            //Console.WriteLine(120);


            //var tempvar = 1.5; //Supar datatype

            //int y = 10;




            ////int l = y + v;
            ////1. Arith +,-,/,*,
            //int v = 10;

            ////v++; // Post increment 
            ////++v; // Pre increment

            ////v = v - 2;

            //Console.WriteLine("V value : " + ++v);
            //Console.WriteLine("</br>");
            //Console.WriteLine(v);

            ////Console.WriteLine("V value : " + --v);

            //Console.ReadLine();

            ////v--; // Post Decrement
            ////--v; // pre Decrement


            Console.ReadLine();

            //2. Logical
            //    3. Comparis
            //    4. assignment
            //    5 Bitware // True or false

        }

        public static void FunctionTest(int a) // Default value
        {
            a = 20;

            //return 10;
        }

        public static void FunctionTest(Employee employee) // Default value
        {
            employee.Name = "Sandeep";

            //return 10;
        }

        public static void FunctionTestReferece(ref int a) // Default value
        {
            a = 50 * a;

            //return 10;
        }


        public static void FunctionTestReferece(ref Employee employee) // Default value
        {
            employee = null;

            //return 10;
        }




        public int f2()
        {
            return 10;
        }

        public class Employee
        {
            public int EmployeeID;
            public string Name;
        }


    }
}
