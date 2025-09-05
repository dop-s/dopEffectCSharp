namespace dopEC.Strings
{
    public class StartString
    {
        private readonly ILogger _logger;

        public StartString(ILogger logger)
        {
            _logger = logger;
        }

        public void StringMetodos(string text)
        {
            
            var stringEntity = new StringEntity { Text = text };

            //_logger.LogDebug("Iniciar Interpolação com tipo format");
            //_logger.LogDebug("Iniciar Interpolação com tipo cifrão");

            InterpolacaoComFormat.stringComFormat(stringEntity);
            _logger.LogInformation("Interpolação com tipo format foi inciada");
            InterpolacaoComCifrao.stringComCifrao(stringEntity);
            _logger.LogInformation("Interpolação com tipo cifrão foi inciada");
            InterpolacaoQuebraN.QueraN(stringEntity);
            _logger.LogInformation("Usando caractere '\\n' para quebra de texto foi inciada");
            InterpolacaoQuebraArroba.queraComArroba(stringEntity);
            _logger.LogInformation("Usando caractere '@' para quebra de texto foi inciada");
        }
    }
}
