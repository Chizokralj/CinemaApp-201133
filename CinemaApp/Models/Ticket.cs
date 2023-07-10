using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class Ticket
    {
        public Guid ID { get; set; }
        [Required]
        public string ImeKarta { get; set; }
        [Required]
        public string DetaliKarta { get; set; }
        [Required]
        public string SlikaKarta { get; set; }
        [Required]
        public int CenaKarta { get; set; }
        [Required]
        public DateTime DateValid { get; set; }

        public List<MovieGenre> Zanrovi;
        public MovieGenre SelektiranZanr{ get; set; }
        public Ticket()
        {
            DateTime temp = DateTime.Now;
            DateValid = new DateTime(temp.Year, temp.Month, temp.Day, temp.Hour, temp.Minute, temp.Second);
        }

    }
}
