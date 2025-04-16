namespace RpgCampanhas.DTO
{
    public class PersonagemDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long JogadorId { get; set; }
        public long CampanhaId { get; set; }
        public string JogadorNome { get; set; }
        public string? ImagePath { get; set; }
    }
}
