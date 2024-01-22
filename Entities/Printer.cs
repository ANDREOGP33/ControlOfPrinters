using System.ComponentModel.DataAnnotations;

namespace ControlOfPrinters.Entities
{
    public class Printer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo IP é obrigatório.")]
        public string Ip { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Setor é obrigatório.")]
        public string Sector { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Serial é obrigatório.")]
        public string Serial { get; set; } = string.Empty;
    }
}
