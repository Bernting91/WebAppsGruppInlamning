using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageClient.Objects
{
    public class Modification
    {
        public int ModificationId { get; set; }
        public string ModificationName { get; set; }

        public Modification(int modificationId, string modificationName)
        {
            ModificationId = modificationId;
            ModificationName = modificationName;
        }

        public Modification() { }
    }
}
