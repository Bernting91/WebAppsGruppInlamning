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
        public string WindowType { get; set; }

        public Car(int carId, string carType, string colour, string tyreType, string windowType)
        {
            CarId = carId;
            CarType = carType;
            Colour = colour;
            TyreType = tyreType;
            WindowType = windowType;
        }

        public Car() { }
    }
}
