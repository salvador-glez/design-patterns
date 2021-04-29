using System;
using System.IO;

namespace Builder
{   
    public abstract class LoggerBuilder
    {
        public abstract void BuildOutput();

        public abstract void BuildConfiguration();
    }

    public class ConsoleLoggerBuilder : LoggerBuilder
    {
        private TextWriter _textWritter;
        private string _format;
        private string _color;

        public ConsoleLogger GetLogger()
        {
            var logger = new ConsoleLogger(_textWritter);
            logger.SetFormat(_format);
            logger.SetColor(_color);
            return logger;
        }

        public override void BuildConfiguration()
        {
           _format = "%DATE%  %PID% %MESSAGE%";
           _color = "#00000";
        }

        public override void BuildOutput()
        {
            _textWritter = Console.Out;
        }
    }

    public class DataBaseLoggerBuilder : LoggerBuilder
    {
        private string _connectionString;
        private int _maxAge;
        private string _logTable;

        public DataBaseLogger GetLogger()
        {
            var logger = new DataBaseLogger(_connectionString);
            logger.SetMaxAge(_maxAge);
            logger.SetLogTable(_logTable);
            return logger;
        }

        public override void BuildConfiguration() => _connectionString = "password=****;uid=123;hostname=localhost";

        public override void BuildOutput()
        {
            _maxAge = 60;
            _logTable = "LOG";
        }
    }

    public class Director
    {
        public LoggerBuilder Builder {get; set;}

        public void BuildLogger()
        {
            Builder.BuildOutput();
            Builder.BuildConfiguration();
        }
    }
}