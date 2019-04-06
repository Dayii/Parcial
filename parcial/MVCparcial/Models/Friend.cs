using System;
using System.ComponentModel.DataAnnotations;

namespace MVCparcial.Models
{
    public enum TipoAmigo
    {
        Conocido,
        Compañero,
        Colega,
        AmigoDeInfancia,
        Pariente

    }

    public class Friend
    {

        [Key]
        public int FriendId { get; set; }

        [Required]
        public string  Name { get; set; }

       
        public string Nickname { get; set; }

        public DateTime Birthdate { get; set; }

        [Required]
        public TipoAmigo Type { get; set; }
    }
}