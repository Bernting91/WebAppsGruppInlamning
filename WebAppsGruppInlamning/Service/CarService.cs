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

        public void AddCar(Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
        }

        public void UpdateCar(Car car)
        {
            Car carToUpdate = db.Cars.FirstOrDefault(c => c.CarId == car.CarId);

            if (carToUpdate != null)
            {
                carToUpdate.CarType = car.CarType;
                carToUpdate.Colour = car.Colour;
                carToUpdate.TyreType = car.TyreType;

                db.SaveChanges();
            }

        }

        public void DeleteCar(int id)
        {
            Car carToDelete = db.Cars.FirstOrDefault(c => c.CarId == id);

            if (carToDelete != null)
            {
                db.Cars.Remove(carToDelete);
                db.SaveChanges();
            }
        }
    }
}
