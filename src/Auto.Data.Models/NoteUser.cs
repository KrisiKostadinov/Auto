using System.ComponentModel.DataAnnotations.Schema;

namespace Auto.Data.Models
{
    public class NoteUser
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string AutoUserId { get; set; }

        [NotMapped]
        public AutoUser AutoUser { get; set; }
    }
}
