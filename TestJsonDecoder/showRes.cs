using System;
using System.Collections.Generic;
using System.Text;

namespace TestJsonDecoder
{
    class showRes : IShowResult
    {
        public void ShowResult(bool data)
        {
            Console.WriteLine("Результат : "+ (data? "Ошибок нет": "Ошибка структуры"));
        }
    }
}
