using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Entities;
using BookApi.Services;
namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService service;
        public BookController()
        {
            this.service = new BookService();
        }
        [Route("GetAllBooks")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Book> Books = service.GetAll();
            return StatusCode(200, Books);
        }
        [HttpGet]
        [Route("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            Book Book = service.GetByName(name);
            return StatusCode(200, Book);
        }
        [HttpGet]
        [Route("GetByAuthor/{author}")]
        public IActionResult GetByAuthor(string author)
        {
            Book Book = service.GetByAuthor(author);
            return StatusCode(200, Book);
        }
        [HttpGet]
        [Route("GetByActor/{director}")]
        public IActionResult GetByPublisher(string publisher)
        {
            Book Book = service.GetByPublisher(publisher);
            return StatusCode(200, Book);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Book Book)
        {
            service.Add(Book);
            return StatusCode(200, Book);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return StatusCode(200, "Book with " + id + " Deleted");
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Book Book)
        {
            service.Edit(Book);
            return StatusCode(200, Book);
        }

    }
}