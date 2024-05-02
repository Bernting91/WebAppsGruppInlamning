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
            Cars.Add(new Car(1, "Coupe", "White", "Sport", "Tinted"));
            this.db = db;
            //Fortsätta med fler
        }

        public List<Car> GetCarList() //Funktion enbart för att testa funktionalitet 
        {
            return db.Cars.ToList();
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
    }
}
