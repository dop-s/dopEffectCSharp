namespace dopEC.Strings
{
    public class StringFactory
    {
        private readonly ILogger<StartString> _logger;
        private readonly StartString _startString;

        public StringFactory()
        {
            _logger = LoggerFactory.Create(builder => builder.AddConsole())
                                 .CreateLogger<StartString>();
            _startString = new StartString(_logger);
        }

        public void Execute(string text)
        {
            _startString.StringMetodos(text);
        }

        public StartString GetStartString()
        {
            return _startString;
        }
    }
}
