using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Entities;
namespace BookApi.Interfaces
{
    public interface BookInterface
    {
        List<Book> GetAll();
        Book GetByAuthor(string actor);
        Book GetByPublisher(string language);
        Book GetByName(string bookname);
        void Add(Book Book);
        void Delete(int id);
        void Edit(Book Book);
    }
}