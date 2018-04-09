using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7 
{
 class methodStub {

        // 1.	Write a method that takes two integers and displays their sum.

        public int showSum (int a, int b) 
        {
            return (int a + int b);
        }

        // 2.	Write a method that takes 5 doubles and returns their average.

        public double showAverage (double a, double b, double c, double d, double e) 
        {
            return ((a + b + c + d + e)/ 5)
        }

        // 3.	Write a method that returns the sum of two randomly generated integers.

        public randomSum ()
        {
            Random num = new Random ();

            int num1 = num.Next(1,50);
            int num2 = num.Next(1,50);

            return (num1 + num2);
        }

        // 4.	Write a method that takes three integers and returns true if their
        //         sum is divisible by 3 and false otherwise.

        public int showSum (int a, int b, int c)
        {
            if (((int a + int b + int c)% 3) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 5.	Write a method that takes two strings and displays the string that has 
        //        fewer characters.

        public string showFewerChar (string stringA, string stringB)
        {
            if (stringA.Length < stringB.Length)
            {
                return stringA;
            }
            else
            {
                return stringB;
            }
        }

        // 6.	Write a method that takes an array of doubles and returns the largest 
        //        value in the array.



        // 7.	Write a method that generates and returns an array of 50 integer values.

        public int[] arrayOfIntegers()
        {
            Number num = new Number();

            int [] arrayOfIntegers = new int[50];

            for (int a = 0; a < 50; a++)
            {
                int num1 = num.Next(1,50);
                arrayOfIntegers[a] = num1;
            }
        }

        // 8.	Write a method that takes two bool variables and return true if they have 
        //        the same value and false otherwise.

        public bool showBool (bool a, bool b)
        {
            if (bool a == bool b)
            {
                return true;
            }
            else
            {
                retrun false;
            }
        }

        // 9.	Write a method that takes an int and a double and returns their product.

        public double showSum (int a, double a)
        {
            return (convert.ToDouble(int a) * double a)
        }

        // 10.	Write a method that takes a two dimensional array of integers and returns 
        //        the average of the entries.

        public double showAverage (int [] [] array)
        {
            int sumOfArray = 0;
            int total = array.Length + array.Length[1].length;

            for (int a = 0; a < array.Length; a++)
            {
                for (int b = 0; b < array[a].Length; b++)
                sumOfArray = sumOfArray + array[a][b];
            }

            return sumOfArray / total;
        }

    }

}