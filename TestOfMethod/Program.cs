using Method;
using System;

namespace TestOfMethod
{
    class Program
    {
        static void Main()
        {
            lab6 method = new lab6();

            //класс название_произвольное = new класс()

            string text = "Мама мыла раму";
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", method.exe6_textRevers(text)[i]);
            }
            Console.ReadLine();
        }
    }
}