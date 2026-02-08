namespace Infra.Models
{
    public class Ficha
    {
        public long Id { get; set; }
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public required long CategoriaId { get; set; }
        public required DateTime CriadoEm { get; set; }
        public bool Concluido { get; set; }

        public string? Resultado { get; set; }
        public virtual ICollection<Etapa>? Etapas { get; set; }
        public DateTime? Prazo { get; set; }
        public DateTime? ConcluidoEm { get; set; }
        
        public virtual Categoria? Categoria { get; set; }
    }
}