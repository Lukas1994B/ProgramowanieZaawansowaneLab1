using System;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Tytuł { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataWydania { get; set; }
        public string Reżyser { get; set; }
        public int LiczbaOskarów { get; set; }
    }
}
