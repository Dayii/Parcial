using System;
using System.ComponentModel.DataAnnotations;

namespace APIparcial.Models
{
    public enum TipoAmigo
    {
        Conocido,               //0
        Compañero,              //1
        Colega,                 //2
        Amigo,                  //3
        AmigoDeInfancia,        //4
        Pariente                //5

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