using System;
using System.ComponentModel.DataAnnotations;

namespace trabajoclases.Models
{
    public enum Tema
    {
        Programacion,
        Ciencia,
        Ingles
    }

    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }  

        [Required]
        public string Descripcion { get; set; } 

        [Required]
        public DateTime Fecha { get; set; }  

        [Required]
        public Tema Tema { get; set; }  

      
    }
}
