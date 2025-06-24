using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD_MVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "La posición es obligatoria.")]
        public string Position { get; set; }


    }
}
