using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Db2Command : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Db2 sorgusu çalıştırılır.");
        }
    }
}
