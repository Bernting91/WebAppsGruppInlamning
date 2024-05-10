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

        [HttpGet("all")] 
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
            if (ModelState.IsValid)
            {
                carService.AddCar(car);
                return new JsonResult("A new car has been built and saved.");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("update")]
        public ActionResult UpdateCar(Car car)
        {
            if (ModelState.IsValid)
            {
                carService.UpdateCar(car);
                return new JsonResult("The car has been updated and saved.");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        
        [HttpDelete("delete")]
        public ActionResult DeleteCar(int id)
        {
            if (ModelState.IsValid)
            {
                carService.DeleteCar(id);
                return new JsonResult("The car has been deleted.");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
