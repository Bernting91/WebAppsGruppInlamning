using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using WebAppsGruppInlamning.Objects;

namespace WebAppsGruppInlamning.Service
{
    public class CarService
    {
        DatabaseContext db;
        List<Car> Cars = new List<Car>();
        public CarService(DatabaseContext db)
        {
            this.db = db;
        }

        public List<Car> GetCarList()
        {
            return db.Cars.ToList();
        }

        public Car GetCarById(int carId)
        {
            return db.Cars.FirstOrDefault(x => x.CarId == carId);
        }

        public bool AddCar(Car car)
        {
            if (car.CarType == "")
            {
                return false;
            }
            db.Cars.Add(car);
            db.SaveChanges();
            return true;
        }

        public bool UpdateCar(Car car)
        {
            Car carToUpdate = db.Cars.FirstOrDefault(c => c.CarId == car.CarId);

            if (carToUpdate != null)
            {
                carToUpdate.CarType = car.CarType;
                carToUpdate.Colour = car.Colour;
                carToUpdate.TyreType = car.TyreType;

                db.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
