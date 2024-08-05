using CancellationTokenAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CancellationTokenAPI.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TestController : ControllerBase
    {
        private readonly ITestRepository _testRepository;
        public TestController(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }


        [HttpGet("GetWithoutCancellationToken")]
        public async Task<IActionResult> GetWithoutCancellationToken()
        {
            await _testRepository.GetDataAsync();
            return Ok("without");
        }

        [HttpGet("GetWithCancellationToken")]
        public async Task<IActionResult> GetWithCancellationToken(CancellationToken cancellationToken)
        {
            await _testRepository.GetDataAsync(cancellationToken);
            return Ok("with");
        }

    }
}
