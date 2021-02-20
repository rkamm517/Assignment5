using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFBookRepository : IBookRepository
    {
        private ProjectDBContext _context;

        public EFBookRepository(ProjectDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
