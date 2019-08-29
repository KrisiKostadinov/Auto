using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Auto.Data.Models
{
    public class AutoUser : IdentityUser
    {
        public AutoUser()
        {
            this.FavouriteCars = new List<Car>();
        }

        public ICollection<Car> FavouriteCars { get; set; }
    }
}
