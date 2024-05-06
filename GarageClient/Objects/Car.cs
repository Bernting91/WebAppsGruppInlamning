using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageClient.Objects
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarType { get; set; }
        public string Colour { get; set; }
        public string TyreType { get; set; }

        public Car(int carId, string carType, string colour, string tyreType)
        {
            CarId = carId;
            CarType = carType;
            Colour = colour;
            TyreType = tyreType;
        }

        public Car(string carType, string colour, string tyreType)
        {
            CarType = carType;
            Colour = colour;
            TyreType = tyreType;
        }

        public Car() { }
    }
}
