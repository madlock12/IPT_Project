using Microsoft.EntityFrameworkCore;

namespace webapi.Models.Entities
{
    [PrimaryKey(nameof(Student_ID))]
    public class student
    {
        public Guid Student_ID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string contact_add { get; set; }
        public string student_email { get; set; }
        public string student_pass { get; set; }
    }
}
