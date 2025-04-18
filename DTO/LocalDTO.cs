namespace RpgCampanhas.DTO
{
    public class LocalDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long CampanhaId { get; set; }
        public string Descricao { get; set; }
        public string Mapa { get; set; }
        public string ImagePath { get; set; }
    }
}
