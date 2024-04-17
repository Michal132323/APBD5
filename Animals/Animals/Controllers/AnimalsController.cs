using Animals.Classes;
using Animals.MockDB;
using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers
{
    [ApiController]
    [Route("animals")]
    public class AnimalsController : ControllerBase
    {
        private readonly IMockDB _mockDb;

        public AnimalsController(IMockDB mockDb)
        {
            _mockDb = mockDb;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mockDb.GetALL());
        }

        [HttpGet("{id}")]
        public IActionResult GetAnimal(int id)
        {
            return Ok(_mockDb.GetAnimal(id));
        }

        [HttpGet("{id}/visits")]
        public IActionResult GetVisits(int id)
        {
            return Ok(_mockDb.GetVisits(id));
        }

        [HttpPost("{id}/visits")]
        public IActionResult AddVisit(int id,string date , string description,int price)
        {
            _mockDb.AddVisit(id, date , description, price);
            return Created();
        }

        [HttpPost]
        public IActionResult Add([FromBody] Animal animal)
        {
            _mockDb.AddAnimal(animal);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult ChangeAnimal(int id, [FromBody] Animal animal)
        {
            _mockDb.ChangeAnimal(animal, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _mockDb.Delete(id);
            return NoContent();
        }
    }
}
