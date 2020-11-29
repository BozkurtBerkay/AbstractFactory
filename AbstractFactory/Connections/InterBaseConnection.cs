using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class InterBaseConnection : Connection
    {

        public override string state
        {
            get { return "Open"; }
        }

        public override bool Connect()
        {
            Console.WriteLine("Interbase Bağlantısı açılacak");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("Interbase Bağlantısı kapatılacak");
            return true;
        }
    }
}
