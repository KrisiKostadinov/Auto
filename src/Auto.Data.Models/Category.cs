using System.Collections.Generic;

namespace Auto.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }

        public bool IsPublic { get; set; }
    }
}
