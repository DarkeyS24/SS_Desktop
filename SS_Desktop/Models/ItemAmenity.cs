using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_Desktop.Models
{
    public class ItemAmenity
    {
        public Int64 Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Int64 ItemId { get; set; }
        public Int64 AmenityId { get; set; }

        public Item Item { get; set; } = new Item();
        public Amenity Amenity { get; set; } = new Amenity();
    }
}
