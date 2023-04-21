using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList_Backend.Models.Models
{
    public class Books
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string image { get; set; }
        public int genreId { get; set; }
        public Genre genre { get; set; }
    }
}
