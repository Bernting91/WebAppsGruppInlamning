using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppsGruppInlamning.Objects
{
    public class Car
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        [Required]
        public string CarType { get; set; }
        [Required]
        public string Colour { get; set; }
        [Required]
        public string TyreType { get; set; }

        public Car()
        {
            
        }

        public Car(int carId, string carType, string colour, string tyreType)
        {
            CarId = CarId;
            CarType = carType;
            Colour = colour;
            TyreType = tyreType;
        }
    }
}
