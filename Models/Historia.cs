namespace RpgCampanhas.Models
{
    public class Historia
    {
        public long Id { get; set; }
        public long CampanhaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual Campanha Campanha { get; set; }
    }
}
