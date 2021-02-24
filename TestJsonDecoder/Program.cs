using System;
using System.Collections.Generic;
using System.Threading;

namespace TestJsonDecoder
{
    class Program
    {
        static ICheck checker;
        static IDataGet dataGetter;
        static IShowResult showResult;
        static Manager manager;

        static void Main(string[] args)
        {
            checker = new JsonTester();
            dataGetter = new DataGetter();
            showResult = new showRes();
            manager = new Manager();
            manager.RunCheck(dataGetter, checker, showResult);
            Console.ReadLine();


        }

     
    }
}

