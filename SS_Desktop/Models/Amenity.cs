using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_Desktop.Models
{
    public class Amenity
    {
        public Int64 Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string IconName { get; set; } = string.Empty;
    }
}
