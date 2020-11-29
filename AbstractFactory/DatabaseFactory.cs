using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
