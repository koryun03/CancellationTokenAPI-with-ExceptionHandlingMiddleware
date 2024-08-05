namespace CancellationTokenAPI.Repositories
{
    public interface ITestRepository
    {
        Task<int> GetDataAsync(CancellationToken cancellationToken = default); // default = CancellationToken.None
    }
}
