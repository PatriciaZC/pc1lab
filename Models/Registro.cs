using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pc1lab.Models
{
    [Table ("registro_bono")]
    public class Registro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Por favor ingrese el Nombre")]
        [Display(Name="Nombre")]
        [Column("nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el Apellido")]
        [Display(Name="Apellido")]
         [Column("apellido")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el Distrito")]
        [Display(Name="Distrito")]
        [Column("distrito")]
        public String District { get; set; }
        
        [Column("acccion")]
        public String Acccion { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name="Edad")]
         [Column("edad")]
        public int Age { get; set; }

         [Required(ErrorMessage = "Por favor, ingrese su genero")]
        [Display(Name="genero")]  
         [Column("genero")]
        public String genero { get; set; }

        public String Response { get; set; }

    }
}