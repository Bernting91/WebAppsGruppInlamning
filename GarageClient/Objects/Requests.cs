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
        public List<Car> GetCars()
        {
            Uri uri = new Uri("https://localhost:7016/api/car/all");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(uri).Result;
            string json = response.Content.ReadAsStringAsync().Result;

            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);

            return cars;
        }

        public void UpdateCar(int id, string carType, string colour, string tireType)
        {
            Car car = new Car(id, carType, colour, tireType);
            string json = JsonConvert.SerializeObject(car);

            Uri uri = new Uri($"https://localhost:7016/api/car/update?id={id}");
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(uri, content).Result;

            Console.WriteLine(response.StatusCode);

            if (response.IsSuccessStatusCode)
                Console.WriteLine("Car Updated.");
            else
                Console.WriteLine("Something went wrong.");

            Thread.Sleep(1000);

        }

        public void AddCar(Car car)
        {
            string json = JsonConvert.SerializeObject(car);

            Uri uri = new Uri("https://localhost:7016/api/car/add");
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(uri, content).Result;

            Console.WriteLine(response.StatusCode);

            if (response.IsSuccessStatusCode)
                Console.WriteLine("Car Added.");
            else
                Console.WriteLine("Something went wrong.");

            Thread.Sleep(1000);
        }

        public void DeleteCar(int id)
        {
            Uri uri = new Uri($"https://localhost:7016/api/car/delete?id={id}");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.DeleteAsync(uri).Result;

            Console.WriteLine(response.StatusCode);

            if(response.IsSuccessStatusCode)
                Console.WriteLine("Car Deleted");
            else
                Console.WriteLine("Something went wrong.");

            Thread.Sleep(1000);
        }
    }
}
