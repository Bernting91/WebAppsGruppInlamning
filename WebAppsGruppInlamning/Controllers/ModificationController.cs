using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppsGruppInlamning.Service;
using WebAppsGruppInlamning.Objects;

namespace WebAppsGruppInlamning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModificationController : ControllerBase
    {
        ModificationService modificationService;

        public ModificationController(ModificationService modificationService)
        {
            this.modificationService = modificationService;
        }

        [HttpGet("all")] //Funktion enbart för att testa funktionalitet
        public List<Modification> GetAllModifications()
        {
            return modificationService.GetModificationList();
        }
    }
}
