using System;
using System.Threading;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Method(20);
        }

        static void Method(object n)
        {
            if (Equals(n,0))
                return;
            
            Thread t = new Thread(Method);
            t.Name = $"Thread {(int)n}";
            t.Start((int)n-1);
            Console.WriteLine(t.Name);
        }
    }
}
