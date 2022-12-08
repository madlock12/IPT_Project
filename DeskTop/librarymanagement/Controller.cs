using librarymanagement.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagement
{
    internal class Controller
    {
        public static async Task<string> Getstudent(string Id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7164/api/librarian/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                if (Id != null)
                {
                    var uri = Path.Combine("GetStudentsInfo", Id);
                    HttpResponseMessage response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string item = await response.Content.ReadAsStringAsync();
                        return item;
                    }
                    else
                    {
                        Console.WriteLine("Internal server Error");
                    }
                }
                //HttpResponseMessage response = await client.GetAsync("GetStudentsInfo");

                return "Student not found";
            }
        }

        public static async Task<string> ViewBookInfo(string Id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7164/api/librarian/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                if (Id != null)
                {
                    var uri = Path.Combine("ViewBookInfo", Id);
                    HttpResponseMessage response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string item = await response.Content.ReadAsStringAsync();
                        return item;
                    }
                    else
                    {
                        Console.WriteLine("Internal server Error");
                    }
                }
                //HttpResponseMessage response = await client.GetAsync("GetStudentsInfo");

                return "Book not found";
            }
        }

        public static async Task<string> IssueBook(borrowing br)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7164/api/librarian/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                if (br.book_ID != null || br.student_ID != null || br.librarian_ID != null)
                {
                    var json = new
                    {
                        //br.Borrowing_ID,
                        br.date_borrowed,
                        br.date_return,
                        br.book_ID,
                        br.student_ID,
                        br.librarian_ID
                    };
                    var jsonItem = JsonConvert.SerializeObject(json);
                    var data = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("IssueBook", data);
                    if(response.IsSuccessStatusCode)
                    {
                        return await (response.Content.ReadAsStringAsync());
                    }
                }
                return string.Empty;
            }
        }

        public static async Task<string> ReturnBook(borrowing br)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7164/api/librarian/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                if (br.book_ID != null || br.Borrowing_ID != null)
                {
                    var json = new
                    {
                        br.Borrowing_ID,
                        br.date_borrowed,
                        br.date_return,
                        br.book_ID,
                        br.student_ID,
                        br.librarian_ID
                    };
                    //json.date_borrowed = "string";
                    var jsonItem = JsonConvert.SerializeObject(json);
                    var data = new StringContent(jsonItem, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("ReturnBook", data);
                    if (response.IsSuccessStatusCode)
                    {
                        return await (response.Content.ReadAsStringAsync());
                    }
                }
                return string.Empty;
            }
        }
    }
}
