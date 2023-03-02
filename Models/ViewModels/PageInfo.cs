using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_GSackley1.Models.ViewModels
{
    public class PageInfo
    {
        // ESTABLISH PAGE INFO VARIABLES
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }
        // Figure out how many pages you need
        public int TotalPages => (int) Math.Ceiling((double) TotalNumBooks / BooksPerPage);

    }
}
