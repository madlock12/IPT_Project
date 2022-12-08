using Microsoft.EntityFrameworkCore;

namespace webapi.Models.Entities
{
    [PrimaryKey(nameof(Librarian_ID))]
    public class librarian
    {
        public Guid Librarian_ID { get; set; }
        public string officer_name { get; set; }
        public string phone_number { get; set; }
        public string Email { get; set; }
        public string joining_date { get; set; }
        public int age { get; set; }
    }
}
