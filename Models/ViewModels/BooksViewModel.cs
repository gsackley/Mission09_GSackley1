using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_GSackley1.Models.ViewModels
{
    // CALLS TWO THINGS SO THAT THEY BOTH CAN BE RETURNED IN THE HOMECONTROLLER
    public class BooksViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}
