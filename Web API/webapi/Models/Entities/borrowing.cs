using Microsoft.EntityFrameworkCore;

namespace webapi.Models.Entities
{
    [PrimaryKey(nameof(Borrowing_ID))]
    public class borrowing
    {
        public Guid Borrowing_ID { get; set; }
        public string date_borrowed { get; set; }
        public string date_return { get; set; }
        public Guid book_ID { get; set; }
        public Guid student_ID { get; set; }
        public Guid librarian_ID { get; set; }
    }
}
