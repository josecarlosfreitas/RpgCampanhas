namespace RpgCampanhas.DTO
{
    public class Ficha3detDTO
    {
        public long Id { get; set; }
        public long? PersonagemId { get; set; }
        public long? NpcId { get; set; }
        public int Forca { get; set; }
        public int Habilidade { get; set; }
        public int Resistencia { get; set; }
        public int Armadura { get; set; }
        public int PoderDeFogo { get; set; }
        public int PontosDeVida { get; set; }
        public int PontosDeMagia { get; set; }

        public string? Vantagens { get; set; }
        public string? Desvantagens { get; set; }
        public string? Historia { get; set; }
        public string? TiposDeDano { get; set; }
        public string? DinheiroEItens { get; set; }
        public string? MagiasConhecidas { get; set; }
        public string? Notas { get; set; }

        public string? Nome { get; set; }
        public int? PontosDeExperiencia { get; set; }
        public int? Pontos { get; set; }
    }
}
