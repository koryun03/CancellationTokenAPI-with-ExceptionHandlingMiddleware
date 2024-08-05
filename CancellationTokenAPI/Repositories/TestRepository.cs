
namespace CancellationTokenAPI.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly ILogger<TestRepository> _logger;
        public TestRepository(ILogger<TestRepository> logger)
        {
            _logger = logger;
        }


        //public async Task<int> GetDataAsync(CancellationToken cancellationToken)
        public async Task<int> GetDataAsync(CancellationToken cancellationToken = default)
        {
            for (int i = 0; i <= 10; i++)
            {
                _logger.LogInformation("Logggggggg" + i);
                await Task.Delay(500, cancellationToken);
            }
            return 0;

        }

    }
}
