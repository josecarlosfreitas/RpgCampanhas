using System.ComponentModel.DataAnnotations;

namespace RpgCampanhas.Models
{
    public class Usuario
    {
        public long Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }
        
        [Required]
        public string Tipo { get; set; } //mestre/jogador

        public virtual ICollection<Campanha> Campanhas { get; set; }
        public virtual ICollection<Personagem> Personagens { get; set; }
        public virtual ICollection<Nota> Notas { get; set; }
    }
}
