using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new InterbaseFactory());
            factory.Start();
            factory.Close();

        }
    }
}
