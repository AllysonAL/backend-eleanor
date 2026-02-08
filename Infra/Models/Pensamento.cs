namespace Infra.Models
{
    public class Pensamento
    {
        public long Id { get; set; }
        public required string Conteudo { get; set; }
        public required DateTime CriadoEm { get; set; }
    }
}