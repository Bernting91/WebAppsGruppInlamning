using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageClient.Objects
{
    public class Requests
    {
        public void GetCars()
        {
            Uri uri = new Uri("https://localhost:7016/api/car/all");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(uri).Result;
            string json = response.Content.ReadAsStringAsync().Result;

            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);

            
            foreach (Car car in cars)
            {
                Console.WriteLine($"Id: {car.CarId} | Type: {car.CarType} | Colour: {car.Colour} | Tires: {car.TyreType} | Windows: {car.WindowType}");
            }
            
        }

        public void AddCar(Car car)
        {
            string json = JsonConvert.SerializeObject(car);

            Uri uri = new Uri("https://localhost:7016/api/car/add");
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(uri, content).Result;

            Console.WriteLine(response.StatusCode);
        }
    }
}
