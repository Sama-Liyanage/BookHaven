using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookHaven.Models.Services;
using BookHeaven.Models.Dto;
using BookHeaven.Models.Entity;

namespace BookHaven.Controllers
{
    public class BookController
    {
        
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        // Get all books
        public async Task<List<Book>> GetAllBooks()
        {
            return (List<Book>)await _bookService.GetAllBooks();
        }

        // Get a book by its ID
        public async Task<Book?> GetBookById(Guid id)
        {
            return await _bookService.GetBookById(id);
        }

        // Search for books using a keyword
        public async Task<List<Book>> SearchBooks(string keyword)
        {
            return (List<Book>)await _bookService.SearchBooks(keyword);
        }

        // Add a new book
        public async Task<bool> AddBook(Book book)
        {
            try
            {
                await _bookService.AddBook(book);
                return true; // Return true if successful
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); // Print error message
                return false; // Return false if failed
            }
        }

        // Update an existing book
        public async Task<bool> UpdateBook(Book book)
        {
            try
            {
                var result = await _bookService.UpdateBook(book);
                return result != null; // Return true if updated successfully
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Delete a book by its ID
        public async Task<bool> DeleteBook(Guid id)
        {
            try
            {
                await _bookService.DeleteBook(id);
                return true; // Return true if deleted
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Get books by a supplier ID
        public async Task<List<Book>> GetBooksBySupplier(Guid supplierId)
        {
            return (List<Book>)await _bookService.GetBooksBySupplier(supplierId);
        }

        // Get the book inventory
        public async Task<List<BookInventory>> GetInventory()
        {
            return (List<BookInventory>)await _bookService.GetInventory();
        }
    }
}
