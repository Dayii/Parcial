using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCparcial5.Models
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
        public string Name { get; set; }


        public string Nickname { get; set; }

        public DateTime Birthdate { get; set; }

        [Required]
        public TipoAmigo Type { get; set; }
    }
}