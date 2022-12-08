using Microsoft.EntityFrameworkCore;

namespace webapi.Models.Entities
{
    [PrimaryKey(nameof(Book_ID))]
    public class book
    {
        public Guid Book_ID { get; set; }
        public string bk_title { get; set; }
        public string bk_name { get; set; }
        public string publisher { get; set; }
        public string author { get; set; }
        public string pub_date { get; set; }
        public string available { get; set; }
    }
}
