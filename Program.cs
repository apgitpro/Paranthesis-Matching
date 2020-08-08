using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParanthesisMatching
{
    class Program
    {
        public static bool CheckString(string exp)
        {
            bool res = true;
            char[] charArray = exp.ToCharArray();
            Stack<string> st = new Stack<string>();

            foreach (char i in charArray)
            {

                string item = i.ToString();
                if (item == "[" || item == "{" || item == "(")
                {

                    st.Push(item);
                }
                else if (st.Count > 0)
                {

                    if (item == "]")
                    {

                        if (st.Peek().ToString() == "[")
                        {
                            st.Pop();
                        }
                        else
                        {
                            res = false;
                        }
                    }
                    else if (item == "}")
                    {

                        if (st.Peek().ToString() == "{")
                        {
                            st.Pop();
                        }
                        else
                        {
                            res = false;
                        }
                    }
                    else if (item == ")")
                    {

                        if (st.Peek().ToString() == "(")
                        {

                            st.Pop();
                        }
                        else
                        {
                            res = false;
                        }

                    }
                }
                else
                {
                    res = false;
                }

            }


            return res;
        }

        public static void Main(string[] args)
        {
            
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string expression = Console.ReadLine();
                bool result = CheckString(expression);
                if (result)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }

            
        }
    }
}
