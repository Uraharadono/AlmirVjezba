using AlmirVjezbaContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirVjezbaContext.Models
{
    public class User : IEntity
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public Role UserRole { get; set; }
        public long UserRoleId { get; set; }
        public Address UserAddress { get; set; }
        public long UserAddressId { get; set; }
    }
}
