using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_Desktop.Models
{
    public class ItemPicture
    {
        public Int64 Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Int64 ItemId { get; set; }
        public string PictureFileName { get; set; } = string.Empty;

        public Item Item { get; set; } = new Item();
    }
}
