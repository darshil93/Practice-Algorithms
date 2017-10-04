/* Array with digits and operator*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = {"4","13","5","/","+" };
            Stack<int> st = new Stack<int>();
            int result;
            foreach(var s in str)
            {
                int tmp;
                if(int.TryParse(s,out tmp))
                {
                    st.Push(tmp);
                }
                if (!int.TryParse(s,out tmp))
                {
                    if (s == "+")
                    {
                        result = st.Pop() + st.Pop();
                        st.Push(result);
                    }
                    else if(s == "-")
                    {
                        result = st.Pop() - st.Pop();
                        st.Push(result);
                    }
                    else if(s=="*")
                    {
                        result = st.Pop() * st.Pop();
                        st.Push(result);
                    }
                    else if (s == "/")
                    {
                        result = st.Pop() / st.Pop();
                        st.Push(result);
                    }
                }
            }
            Console.WriteLine(st.Peek().ToString());
            Console.ReadLine();
        }
    }
}
