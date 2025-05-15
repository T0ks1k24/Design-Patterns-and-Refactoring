namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log1 = Logger.GetInstance();
            log1.LogMessage("First message");

            Logger log2 = Logger.GetInstance();
            log2.LogMessage("Second message");

            Console.WriteLine(ReferenceEquals(log1, log2));
            Console.ReadLine();
        }
    }

    class Logger
    {
        private static Logger _inctance;
        private static readonly object _lock = new object();
        private string _log;
        private Logger()
        {
            _log = string.Empty;
        }   

        public static Logger GetInstance()
        {
            if (_inctance == null) {
                lock (_lock) {
                    if (_inctance == null) {
                        _inctance = new Logger();
                    }
                }       
            }
            return _inctance;
        }

        public void LogMessage(string message)
        {
            _log += message + "\n";
            Console.WriteLine($"Log: {message}");
        }
    }
}
