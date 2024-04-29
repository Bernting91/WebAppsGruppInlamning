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
    }
}
