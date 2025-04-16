namespace RpgCampanhas.Models
{
    public class NPC
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long CampanhaId { get; set; }
        public string Descricao { get; set; }
        public string TipoFicha { get; set; }

        public string ImagePath { get; set; }

        public virtual Campanha Campanha { get; set; }
        public virtual ICollection<Ficha3det> Ficha3Dets { get; set; }
    }
}
