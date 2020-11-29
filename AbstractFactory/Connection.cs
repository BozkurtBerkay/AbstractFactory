using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();

        public abstract string state
        {
            get;
        }
    }
    public abstract class Command
    {
        public abstract void Execute(string query);

    }

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
    public class InterbaseConnection : Connection
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

    public class Db2Command : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Db2 sorgusu çalıştırılır.");
        }
    }
    public class InterbaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Interbase sorgusu çalıştırılır.");
        }
    }

    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }

    public class Db2Factory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new Db2Command();
        }

        public override Connection CreateConnection()
        {
            return new Db2Connection();
        }
    }
    public class InterbaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterbaseConnection();
        }
    }
    public class Factory
    {
        private DatabaseFactory _dbFactory;
        private Connection _connection;
        private Command _command;

        public Factory(DatabaseFactory databaseFactory)
        {
            _dbFactory = databaseFactory;

            _connection = _dbFactory.CreateConnection();
            _command = _dbFactory.CreateCommand();
        }

        public void Start()
        {
            _connection.Connect();
            if(_connection.state=="Open")
            {
                _command.Execute("Select...");
            }
        }
        public void Close()
        {
            _connection.Disconnect();
            if (_connection.state == "Close")
            {
                _command.Execute("");
            }
        }
    }
}
