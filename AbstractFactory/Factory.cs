using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
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
            if (_connection.state == "Open")
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
