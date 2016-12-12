using System;
using Method;

namespace TestOfMethod
{
    class Program
    {
        static void Main()
        {
            string text = "Мама мыла раму";
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", lab6.exe6_textRevers(text)[i]);
            }
            Console.ReadLine();
            /* 
             * Самый банальный пример работы подзагрузки библиотеки Method. 
             * Имеет в себе 8 методов. В примере используется метод №6
             * На вход мы отправляем переменную типа string
             * На выходе получаем массив, и используя цыкл, выводим из него данные 
             * Данный метод меняет слова местами зеркально, первую и последнюю букву делает заглавной
             * 
             */
        }
    }
}