namespace RpgCampanhas.DTO
{
    public class CampanhaDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public long MestreId { get; set; }
        public string MestreNome { get; set; }
        public string? ImagePath { get; set; }
    }
}
