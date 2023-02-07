using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume_API_Interactor;
using resume_MODELS.API;

namespace resume_web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private Interactor _db;
        public ResumeController()
        {
            _db = new Interactor();
        }
        [HttpGet("/Resume")]
        public Root GetResume()
        {
            return _db.GetResumeFromDb();
        }
    }
}
