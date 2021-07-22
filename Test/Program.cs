using System;
using Covalent_Wrapper;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CovalentSession sess=new CovalentSession("YOUR_KEY_HERE");
            CovalentClassA csa = new CovalentClassA(sess);
            Console.WriteLine(csa.getAllChain());
        }
    }
}
