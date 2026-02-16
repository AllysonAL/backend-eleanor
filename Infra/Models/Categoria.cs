namespace Infra.Models
{
    public class Categoria
    {
        public long Id { get; set; }
        public required string Nome { get; set; }
        public required long CaixaId { get; set; }

        public long? CategoriaPaiId { get; set; }
        
        public virtual Caixa? Caixa { get; set; }
        public virtual Categoria? CategoriaPai { get; set; }
        public virtual ICollection<Categoria>? SubCategorias { get; set; }

        public bool EhSubCategoria => CategoriaPaiId.HasValue;
    }
}