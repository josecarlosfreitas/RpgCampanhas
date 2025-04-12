namespace RpgCampanhas.Models
{
    public class Personagem
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long JogadorId { get; set; }
        public long CampanhaId { get; set; }
        public string TipoFicha { get; set; }

        public virtual Usuario Jogador { get; set; }
        public virtual Campanha Campanha { get; set; }
        public virtual ICollection<Ficha3det> Ficha3Dets { get; set; }
    }
}
