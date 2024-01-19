namespace PokemonReviewApp.Models
{
    // Esta es una join table, porque si hacemos esto en las tablas existente tendriamos data redudante, es mejor crear tablas nuevas con informacion de varias tablas
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Category Category { get; set; }
    }
}
