using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory _InterBaseFactory = new Factory(new InterBaseFactory());
            _InterBaseFactory.Start();
            _InterBaseFactory.Close();

            Console.WriteLine();

            Factory _Db2Factory = new Factory(new Db2Factory());
            _Db2Factory.Start();
            _Db2Factory.Close();
        }
    }
}
