using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageClient.Objects
{
    public class Menu
    {
        Requests request = new Requests();
        List<Car> cars = new List<Car>();

        public void Run()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Welcome To Your Garage");
                Console.WriteLine("=====================");
                Console.WriteLine("1. Show Cars");
                Console.WriteLine("2. Add Car");
                Console.WriteLine("3. Delete Car");
                Console.WriteLine("4. Update Car");
                Console.WriteLine("0. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowCars();
                        break;
                    case "2":
                        AddCarMenu();
                        break;
                    case "0":
                        loop = false;
                        break;
                }
            }
        }

        private void AddCarMenu()
        {
            bool loop = true;
            
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Add Car");
                Console.WriteLine("=========");
                Console.WriteLine("Type");
                Console.WriteLine("------");
                Console.WriteLine("1. Coupe");
                Console.WriteLine("2. Sport");

                string input = Console.ReadLine();

                if (input == "0")
                {
                    loop = false;
                }
            }
        }

        private void AddCar()
        {
            request.AddCar(new Car(1, "Coupe", "White", "Sport", "Tinted"));
            Console.ReadKey();
        }

        private void ShowCars()
        {
            Console.Clear();

            request.GetCars();

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
