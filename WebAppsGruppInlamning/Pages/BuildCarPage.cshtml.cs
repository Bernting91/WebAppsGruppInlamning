using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage;
using WebAppsGruppInlamning.Objects;

namespace WebAppsGruppInlamning.Pages
{
    public class BuildCarPageModel : PageModel
    {
        /*private readonly DatabaseContext db;
        public BuildCarPageModel(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IActionResult OnPostSaveData(Car car)
        {
            Console.WriteLine(car);
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return new JsonResult("A new car has been saved.");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }*/
    }
}
