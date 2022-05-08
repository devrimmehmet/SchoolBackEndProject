using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        //LessonManager lessonManager = new LessonManager(new EfLessonDal());
        private ILessonService _lessonService;

        public LessonsController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpPost("add")]
        public IActionResult Add(Lesson lesson)
        {
            _lessonService.Add(lesson);
            return Ok();
        }
    }
}
