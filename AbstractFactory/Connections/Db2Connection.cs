using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Db2Connection : Connection
    {
        public override string state
        {
            get { return "Open"; }
        }

        public override bool Connect()
        {
            Console.WriteLine("DB2 Bağlantısı açılacak");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("DB2 Bağlantısı kapatılacak");
            return true;
        }
    }
}
