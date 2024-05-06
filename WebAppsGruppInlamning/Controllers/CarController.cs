using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppsGruppInlamning.Service;
using WebAppsGruppInlamning.Objects;

namespace WebAppsGruppInlamning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        CarService carService;

        public CarController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("all")] //Funktion enbart för att testa funktionalitet 
        public List<Car> GetAllCars()
        {
            return carService.GetCarList();
        }

        [HttpGet("getCar")]
        public Car GetCarById(int id)
        {
            return carService.GetCarById(id);
        }

        [HttpPost("add")]
        public ActionResult AddCar(Car car)
        {
            bool success = carService.AddCar(car);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("update")]
        public ActionResult UpdateCar(Car car)
        {
            bool success = carService.UpdateCar(car);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
