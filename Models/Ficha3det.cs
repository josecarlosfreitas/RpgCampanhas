﻿namespace RpgCampanhas.Models
{
    public class Ficha3det
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

        public string Vantagens { get; set; }
        public string Desvantagens { get; set; }
        public string Historia { get; set; }
        public string Equipamento { get; set; }
        public string Pericias { get; set; }
        public string Magias { get; set; }
        public string Notas { get; set; }

        public virtual Personagem Personagem { get; set; }
        public virtual NPC Npc { get; set; }
    }
}
