using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public List<OrderDto> Orders { get; set; }

        public List<StorageChangeDto> StorageChanges { get; set; }

        public UserDto()
        {
            Orders = new List<OrderDto>();
            StorageChanges = new List<StorageChangeDto>();
        }
    }
}
