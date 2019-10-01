using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Books.Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ObligatoriskOpgave4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> data = new List<Book>()
        {
            new Book("Scoops, a guide","Aaron B. Carlson", 200, "HDLEKNSIBN218"),
            new Book("Shrubberies", "The Knight Who Say Ni", 3000, "LOKNGTREDF852"),
            new Book("The Round Table", "Knights of Camelot", 100, "NILHUIONIT132"),
            new Book("How to get a Million Subscribers", "HatFilms", 250, "LKJHGFDSAQ524")
        };

        // GET: api/Book
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return data;
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public Book Get(string id)
        {
            return data.Find(b => b.Isbn == id);
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            data.Add(value);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Book value)
        {
            Book book = Get(id);
            if (book !=null)
            {
                book.Isbn = value.Isbn;
                book.Author = value.Author;
                book.Pages = value.Pages;
                book.Title = value.Title;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Book book = Get(id);
            if (book != null)
            {
                data.Remove(book);
            }
        }
    }
}
