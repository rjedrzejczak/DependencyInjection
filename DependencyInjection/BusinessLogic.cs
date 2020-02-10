namespace DependencyInjection
{
    public class BusinessLogic : IBusinessLogic
    {
        private ILogger _logger;

        public BusinessLogic(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessData()
        {
            _logger.LogMessage("test message");
        }
    }
}