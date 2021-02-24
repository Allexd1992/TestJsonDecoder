using System;
using System.Collections.Generic;
using System.Text;

namespace TestJsonDecoder
{
    public class DataGetter : IDataGet
    {
        public string GetData()
        {
            Console.WriteLine("Введите структуру:");
            return Console.ReadLine();
        }
    }
}
