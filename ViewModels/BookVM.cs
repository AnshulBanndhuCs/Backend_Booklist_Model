using BookList_Backend.Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList_Backend.Models.ViewModels
{
    public class BookVM
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string image { get; set; }
        //public Genre Genre { get; set; }
        public int GenreId { get; set; }
        //public string GenreName { get; set; }
        //public Books Books { get; set; }
        //public IEnumerable<SelectListItem> bookListItems { get; set; }
    }
}
