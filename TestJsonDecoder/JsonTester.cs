using System;
using System.Collections.Generic;
using System.Text;

namespace TestJsonDecoder
{
   public class JsonTester: ICheck
    {
        List<char> list;
        public JsonTester()
        {
            list = new List<char>();
        }

        public bool Check(string Data)
        {
            if (Data == "") return false;
            var data = Data.ToCharArray();
            foreach (var item in data)
            {
                if ("{([".Contains(item))
                { 
                    list.Add(item);
                }

                if (")}]".Contains(item))
                {
                    if (list.Count > 0 && ((list[list.Count - 1] == '(' && item == ')') || (list[list.Count - 1] == '{' && item == '}') || (list[list.Count - 1] == '[' && item == ']')))
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            if (list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
