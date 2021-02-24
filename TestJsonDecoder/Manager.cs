using System;
using System.Collections.Generic;
using System.Text;

namespace TestJsonDecoder
{
    public class Manager
    {
       public void RunCheck(IDataGet getter, ICheck checker, IShowResult show)
        {
            show.ShowResult(checker.Check(getter.GetData()));
        }
    }
}
