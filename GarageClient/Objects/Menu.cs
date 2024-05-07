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
            cars = request.GetCars();
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
                Console.WriteLine("3. Update Car");
                Console.WriteLine("4. Delete Car");
                Console.WriteLine("0. Exit");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowCars();
                        break;
                    case "2":
                        AddCarMenu();
                        break;
                    case "3":
                        UpdateCarMenu();
                        break;
                    case "4":
                        DeleteCarMenu();
                        break;
                    case "0":
                        loop = false;
                        break;
                }
            }
        }

        private void DeleteCarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Delete a car by ID");
                Console.WriteLine();

                foreach (Car car in cars)
                {
                    Console.WriteLine($"Id: {car.CarId} | Type: {car.CarType} | Colour: {car.Colour} | Tires: {car.TyreType}");
                }
                Console.WriteLine("0. Back");
                Console.WriteLine();

                try
                {
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (id == 0)
                        return;

                    request.DeleteCar(id);
                    cars = request.GetCars();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(500);
                }
            }
        }

        private void UpdateCarMenu()
        {
            string carType;
            string colour;
            string tires;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a car by ID");
                Console.WriteLine();

                foreach (Car car in cars)
                {
                    Console.WriteLine($"Id: {car.CarId} | Type: {car.CarType} | Colour: {car.Colour} | Tires: {car.TyreType}");
                }
                Console.WriteLine("0. Back");
                Console.WriteLine();

                try
                {
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (id == 0)
                        return;

                    carType = ChooseCarType("Edit");
                    if (carType == "")
                        return;

                    colour = ChooseCarColour("Edit");
                    if (colour == "")
                        return;

                    tires = ChooseTires("Edit");
                    if (tires == "")
                        return;

                    request.UpdateCar(id, carType, colour, tires);
                    cars = request.GetCars();
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(500);
                }
            }
        }

        private void AddCarMenu()
        {
            string carType;
            string colour;
            string tires;

            carType = ChooseCarType("Add");
            if (carType == "")
                return;

            colour = ChooseCarColour("Add");
            if (colour == "")
                return;

            tires = ChooseTires("Add");
            if (tires == "")
                return;

            Car car = new Car(carType, colour, tires);
            AddCar(car);
            cars = request.GetCars();
        }

        private string ChooseCarType(string addorEdit)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{addorEdit} Car");
                Console.WriteLine("=========");
                Console.WriteLine("Type");
                Console.WriteLine("---------");
                Console.WriteLine("1. Ferrari");
                Console.WriteLine("2. Monster Truck");
                Console.WriteLine("3. SUV");
                Console.WriteLine("0. Back");



                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return "Ferrari";
                    case "2":
                        return "Monster Truck";
                    case "3":
                        return "SUV";
                    case "0":
                        return "";
                }
            }
        }

        private string ChooseCarColour(string addorEdit)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{addorEdit} Car");
                Console.WriteLine("=========");
                Console.WriteLine("Colour");
                Console.WriteLine("---------");
                Console.WriteLine("1. Red");
                Console.WriteLine("2. Blue");
                Console.WriteLine("3. Yellow");
                Console.WriteLine("0. Back");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return "Red";
                    case "2":
                        return "Blue";
                    case "3":
                        return "Yellow";
                    case "0":
                        return "";
                }
            }
        }

        private string ChooseTires(string addorEdit)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{addorEdit} Car");
                Console.WriteLine("=========");
                Console.WriteLine("Tires");
                Console.WriteLine("---------");
                Console.WriteLine("1. Regular");
                Console.WriteLine("2. Monster Truck");
                Console.WriteLine("0. Back");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return "Regular";
                    case "2":
                        return "Monster Truck";
                    case "0":
                        return "";
                }
            }
        }

        private void AddCar(Car car)
        {
            request.AddCar(car);
            Console.ReadKey();
        }

        private void ShowCars()
        {
            Console.Clear();

            foreach (Car car in cars)
            {
                Console.WriteLine($"Id: {car.CarId} | Type: {car.CarType} | Colour: {car.Colour} | Tires: {car.TyreType}");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
