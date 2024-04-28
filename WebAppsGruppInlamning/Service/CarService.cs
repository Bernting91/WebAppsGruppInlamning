using WebAppsGruppInlamning.Objects;

namespace WebAppsGruppInlamning.Service
{
    public class CarService
    {
        List<Car> carList = new List<Car>();
        public CarService() 
        {
            carList.Add(new Car(1, "Coupe", "White", "Sport", "Tinted"));
            //Fortsätta med fler
        }

        public List<Car> GetCarList() //Funktion enbart för att testa funktionalitet 
        {
            return carList; 
        }
    }
}
