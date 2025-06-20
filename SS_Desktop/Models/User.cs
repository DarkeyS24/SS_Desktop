using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SS_Desktop.Models
{
    public class User
    {
        public Int64 Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Int64 UserTypeId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public bool Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public int FamilyCount { get; set; }

        public UserType? UserType { get; set; }
    }
}
