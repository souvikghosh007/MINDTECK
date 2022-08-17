using System;
namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int mynum = 25;
            float myfloat = 5.2f;
            bool mybool = true;
            Console.WriteLine(Convert.ToString(mynum));
            Console.WriteLine(Convert.ToInt32(myfloat));
            Console.WriteLine(Convert.ToDouble(myfloat));
            Console.WriteLine(Convert.ToInt32(mybool));
        }
    }
}


