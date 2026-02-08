namespace Infra.Models
{
    public class Etapa
    {
        public long Id { get; set; }
        public required long FichaId { get; set; }
        public required string Conteudo { get; set; }
        public bool Concluido { get; set; }

        public virtual Ficha? Ficha { get; set; }
    }
}