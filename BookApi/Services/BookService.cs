using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Entities;
using BookApi.Interfaces;

namespace BookApi.Services
{
    public class BookService : BookInterface
    {
        private readonly AssignmentDBContext context;
        public BookService()
        {
            this.context = new AssignmentDBContext();
        }
        public void Add(Book Book)
        {
            context.Books.Add(Book);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Book Book = context.Books.SingleOrDefault(i => i.BookId == id);
            context.Books.Remove(Book);
            context.SaveChanges();
        }

        public void Edit(Book Book)
        {
            context.Books.Update(Book);
            context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }
        public Book GetByName(string bookname)
        {
            Book Book = context.Books.SingleOrDefault(i => i.BookName == bookname);
            return Book;
        }

        public Book GetByAuthor(string author)
        {
            Book Book = context.Books.SingleOrDefault(i => i.Author == author);
            return Book;
        }

        public Book GetByPublisher(string publisher)
        {
            Book Book = context.Books.SingleOrDefault(i => i.Publisher == publisher);
            return Book;
        }
    }
}