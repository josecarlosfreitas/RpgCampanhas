namespace RpgCampanhas.Models
{
    public class Local
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long CampanhaId { get; set; }
        public string Descricao { get; set; }
        public string Mapa { get; set; }

        public virtual Campanha Campanha { get; set; }
    }
}
