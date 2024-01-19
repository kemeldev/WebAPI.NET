namespace PokemonReviewApp.Models
{
    // Models o POCO stands for "Plain Old CLR Object." It is a design principle used in OOP where you create simple, lightweight classes that primarily serve as data containers without containing much behavior or logic. POCO classes are often used to represent data structures, entities, or models in an application.

    // Para el caso de API los POCO son para representar datos de las bases de datos
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
