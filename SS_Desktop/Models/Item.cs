
namespace SS_Desktop.Models
{
    public class Item
    {
        public Int64 Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();    
        public Int64 UserId { get; set; }
        public Int64 ItemTypeId { get; set; }
        public Int64 AreaId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public int NumberOfBeds { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public string ExactAddress { get; set; } = string.Empty;
        public string ApproximateAddress { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string HostRules { get; set; } = string.Empty;
        public int MinimumNights { get; set; }
        public int MaximumNights { get; set; }

        public User User { get; set; } = new User();
        public ItemType ItemType { get; set; } = new ItemType();
        public Area Area { get; set; } = new Area();
    }
}
