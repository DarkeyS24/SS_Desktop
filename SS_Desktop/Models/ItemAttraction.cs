using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_Desktop.Models
{
    public class ItemAttraction
    {
        public Int64 Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Int64 ItemId { get; set; }
        public Int64 AttractionId { get; set; }
        public decimal Distance { get; set; } = 0.0m; // Default distance is 0.0
        public Int64 DurationOnFoot { get; set; }
        public Int64 DurationByCar { get; set; }

        public Item Item { get; set; } = new Item();
        public Attraction Attraction { get; set; } = new Attraction();
    }
}
