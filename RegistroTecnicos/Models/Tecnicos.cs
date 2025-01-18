using System.ComponentModel.DataAnnotations;


namespace RegistroTecnicos.Models
{
    public class Tecnicos
    {
        [Key]
        public int IdTecnico { get; set; }


        [Required(ErrorMessage = "este campo es obligatorio")]

        public string Nombre { get; set; } = string.Empty!;// para que nombre no sea nulo
        public int SueldoHora { get; set; }

    }
}