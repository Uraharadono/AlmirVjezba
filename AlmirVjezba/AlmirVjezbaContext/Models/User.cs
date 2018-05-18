using AlmirVjezbaContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AlmirVjezbaContext.Models
{
    public class User : IEntity
    {
        [Key]
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public List<Role> UserRole { get; set; }
        public long UserRoleId { get; set; }
        public long UserAddressId { get; set; }
        [ForeignKey("UserAddressId")]
        public List<Address> UserAddress { get; set; }
    }
}
