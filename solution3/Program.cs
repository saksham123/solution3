using System;

namespace solution3
{
    class Program
    {
        public static long decimalToBinary()
        {
            string x, result;

            Console.Write("Input a Number to convert to binary");//input number from the user
            x = Console.ReadLine();//put number into x
            int  y = Convert.ToInt32(x);//convert to integer
            result = "";
            while (y>1)//while loop where num value is greater than 1
            {
                int remainder = y % 2;//check remainder when divided by 2
                result = Convert.ToString(remainder) + result;//enter result from right to left
                y /= 2;// change value of num to qutioent when num is divided by 2
            }
            result = Convert.ToString(y) + result;//add num the last qutioent 1 to result
            Console.WriteLine("Binary: {0}", result);//display the binary value
            Console.ReadLine();
            return 0;
        }
        static void Main(string[] args)
        {
            try
            {
                decimalToBinary();//call the method
            }
            catch
            {
                Console.WriteLine("write a valid input");
            }
        }
    }
}
