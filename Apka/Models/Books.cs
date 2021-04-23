using System;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Company { get; set; }
        public decimal Author { get; set; }
    }
}
