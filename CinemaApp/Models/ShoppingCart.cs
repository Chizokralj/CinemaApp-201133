using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class ShoppingCart
    {
        public Guid id{ get; set; }
        public string GazdaId { get; set; }
        public User Gazda{ get; set; }
    }
}
