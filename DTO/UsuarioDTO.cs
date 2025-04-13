namespace RpgCampanhas.DTO
{
    public class UsuarioDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; } //mestre/jogador
    }
}
