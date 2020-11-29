using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class InterBaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Interbase sorgusu çalıştırılır.");
        }
    }

}
