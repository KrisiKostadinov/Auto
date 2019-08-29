using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auto.Data.Models
{
    public class FavouritesUser
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [NotMapped]
        public AutoUser AutoUser { get; set; }

        [NotMapped]
        public ICollection Cars { get; set; }
    }
}
