using System;

namespace CADelegate
{
    internal class Program
    {
        //delegate void MDelegate();
        //Action, Func, Pred
        static void Main(string[] args)
        {
            //M2(M1);
            Action action = M1;
            M2(action);
            Console.ReadKey();
        }
        static void M1()
        {

            Console.WriteLine("M1");
        }

        static void M2(/*MDelegate mdel*/ Action action)
        {
            //mdel();
            action();
            Console.WriteLine("M2");
        }
    }
}