using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoIndexing.Services;

namespace WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndexController : ControllerBase
    {
        private readonly IndexCreationService _indexCreationService;
        public IndexController(IndexCreationService indexCreationService)
        {
            this._indexCreationService = indexCreationService;
        }


        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<string> CreateIndexAsync()
        {
            return await this._indexCreationService.CreateIndexAsync();
        }

    }
}
