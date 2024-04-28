using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppsGruppInlamning.Objects
{
    public class Car
    {
        //Tänkte om vi skall ha med CarName, CarBrand

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
    }
}
