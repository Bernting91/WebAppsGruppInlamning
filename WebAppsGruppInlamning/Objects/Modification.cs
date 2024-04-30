using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppsGruppInlamning.Objects
{
    public class Modification
    {
        [Key]
        public int ModificationId { get; set; }
        [Required]
        public string ModificationName { get; set; }

        public Modification(int modificationId, string modificationName)
        {
            ModificationId = modificationId;
            ModificationName = modificationName;
        }
    }
}
