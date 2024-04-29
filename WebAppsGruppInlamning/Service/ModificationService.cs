using WebAppsGruppInlamning.Objects;

namespace WebAppsGruppInlamning.Service
{
    public class ModificationService
    {
        List<Modification> modificationList = new List<Modification>();

        public ModificationService()
        {
            modificationList.Add(new Modification(1, "Turbo"));
            //Fortsätta med fler
        }

        public List<Modification> GetModificationList() //Funktion enbart för att testa funktionalitet
        {
            return modificationList;
        }
    }
}
