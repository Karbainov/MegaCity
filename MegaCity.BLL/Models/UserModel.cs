using MegaCity.DAL.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Role { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public List<OrderModel> Orders { get; set; }

        public List<StorageChangeModel> StorageChanges { get; set; }

        public UserModel()
        {
            Orders = new List<OrderModel>();
            StorageChanges = new List<StorageChangeModel>();
        }
    }
}
