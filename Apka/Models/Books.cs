using System;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Tytuł { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataWydania { get; set; }
        public string Wydawnictwo { get; set; }
        public string Autor { get; set; }
    }
}
