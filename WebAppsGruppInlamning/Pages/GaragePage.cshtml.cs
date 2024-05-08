using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlConnector;
using WebAppsGruppInlamning.Objects;


namespace WebAppsGruppInlamning.Pages
{
    public class GaragePageModel : PageModel
    {
        public List<Car> savedCars {  get; set; }
        public void OnGet()
        {
            savedCars = new List<Car>();

            string connectionString = "server=localhost;uid=term;password=hejhej123;database=WebAppsGruppInlamning";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Cars";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int carId = reader.GetInt32("CarId");
                            string carType = reader.GetString("CarType");
                            string colour = reader.GetString("Colour");
                            string tyreType = reader.GetString("TyreType");

                            savedCars.Add(new Car { CarId = carId, CarType = carType, Colour = colour, TyreType = tyreType });
                        }
                    }
                }
            }
        }
    }
}
