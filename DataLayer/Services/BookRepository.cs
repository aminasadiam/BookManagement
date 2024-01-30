using DataLayer.Context;
using DataLayer.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class BookRepository
    {
        private readonly BookContext context;

        public BookRepository(BookContext context)
        {
            this.context = context;
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public Book GetBookById(uint id)
        {
            return context.Books.Find(id);
        }

        public Book InsertBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return book;
        }

        public Book RemoveBook(uint id)
        {
            var book = context.Books.Find(id);  
            context.Books.Remove(book);
            context.SaveChanges();
            return book;
        }

        public Book UpdateBook(Book book)
        {
            context.Books.Update(book);
            context.SaveChanges();
            return book;
        }
    }

}
