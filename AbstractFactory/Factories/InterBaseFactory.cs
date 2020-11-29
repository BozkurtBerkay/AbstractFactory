using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class InterBaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterBaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterBaseConnection();
        }
    }
}
