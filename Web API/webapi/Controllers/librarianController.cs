using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using webapi.Data;
using webapi.Models.Entities;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]//url route
    public class librarianController : Controller
    {
        private readonly ProjectDbContext projectDbContext;

        public librarianController(ProjectDbContext projectDbContext)
        {
            this.projectDbContext = projectDbContext;
        }
        //view student by id
        [HttpGet]
        [Route("GetStudentsInfo/{Student_ID:Guid}")]
        public async Task<IActionResult> GetStudentsInfo([FromRoute] Guid Student_ID)
        {
            var temp = await projectDbContext.student.FindAsync(Student_ID);
            if(temp == null) 
            {
                return NotFound();
            }
            else
            {
                return Ok(temp);
            }
        }

        [HttpGet]
        [Route("ViewBookInfo/{Book_ID:Guid}")]
        public async Task<IActionResult> ViewBookInfo([FromRoute] Guid Book_ID)
        {
            var temp = await projectDbContext.book.FindAsync(Book_ID);
            if (temp == null)
            {
                return NotFound();
            }
            return Ok(temp);
        }

        [HttpPost]
        //[Route("IssueBook/{Book_ID:Guid}/{Student_ID:Guid}/{Librarian_ID:Guid}")]
        [Route("IssueBook")]
        //public async Task<IActionResult> IssueBook([FromRoute] Guid Book_ID, [FromRoute] Guid Student_ID, [FromRoute] Guid Librarian_ID,string b_date, string r_date)//yyy-mm-dd
        public async Task<IActionResult> IssueBook(borrowing br)//yyy-mm-dd
        {
            br.Borrowing_ID = Guid.NewGuid();
            //var item=new borrowing
            //{
                //book_ID= Book_ID,
                //date_borrowed=b_date,
                //date_return=r_date,
                //Borrowing_ID=Guid.NewGuid(),
                //student_ID=Student_ID,
                //librarian_ID=Librarian_ID,
            //};
            await projectDbContext.borrowing.AddAsync(br);//adding a new entry in borrowing table

            var existingBook = await projectDbContext.book.FindAsync(br.book_ID);
            if (existingBook == null) 
            { 
                return NotFound(); 
            }
            existingBook.available="No";

            await projectDbContext.SaveChangesAsync();
            return Ok(br);
        }

        [HttpPost]
        //[Route("ReturnBook/{Book_ID:Guid}/{Borrowing_ID:Guid}")]
        [Route("ReturnBook")]
        public async Task<IActionResult> ReturnBook(borrowing br)
        {
            var existingBorrowing = await projectDbContext.borrowing.FindAsync(br.Borrowing_ID);
            if (existingBorrowing == null) 
            { 
                return NotFound(); 
            }
            else
            {
                var existingBook = await projectDbContext.book.FindAsync(br.book_ID);
                existingBook.available = "Yes";
                await projectDbContext.SaveChangesAsync();
            }
            return Ok(existingBorrowing);

        }
        [HttpPost]
        [Route("AddLibrarian")]
        public async Task<IActionResult> AddLibrarian(string of_name,string phone, string email, string j_date, int age)
        {
            var lib = new librarian
            {
                Librarian_ID = Guid.NewGuid(),
                officer_name = of_name,
                phone_number = phone,
                Email = email,
                joining_date = j_date,
                age = age,
            };
            await projectDbContext.librarian.AddAsync(lib);
            await projectDbContext.SaveChangesAsync();
            return Ok(lib);
        }

        [HttpPost]
        [Route("AddStudent")]
        public async Task<IActionResult> AddStudent(string fname, string lname, string gender, string add, int age, string email, string pas)
        {
            var stdd = new student
            {
                Student_ID = Guid.NewGuid(),
                fname = fname,
                lname = lname,
                gender = gender,
                contact_add = add,
                student_email = email,
                student_pass = pas,
                age = age,
            };
            await projectDbContext.student.AddAsync(stdd);
            await projectDbContext.SaveChangesAsync();
            return Ok(stdd);
        }

        [HttpPost]
        [Route("AddBook")]
        public async Task<IActionResult> AddBook(string book_Title, string Book_name, string publisher, string publishing_date, string available, string Author)
        {
            var bok = new book
            {
                Book_ID = Guid.NewGuid(),
                bk_title = book_Title,
                bk_name=Book_name,
                publisher= publisher,
                pub_date= publishing_date,
                available=available,
                author= Author,
            };
            await projectDbContext.book.AddAsync(bok);
            await projectDbContext.SaveChangesAsync();
            return Ok(bok);
        }
    }
}
