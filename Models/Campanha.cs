namespace RpgCampanhas.Models
{
    public class Campanha
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public long MestreId { get; set; }
        public string ImagePath { get; set; }

        public virtual Usuario Mestre { get; set; }
        public virtual ICollection<Personagem> Personagens { get; set; }
        public virtual ICollection<NPC> NPCs { get; set; }
        public virtual ICollection<Local> Locais { get; set; }
        public virtual ICollection<Historia> Historias { get; set; }
        public virtual ICollection<Nota> Notas { get; set; }
    }
}
