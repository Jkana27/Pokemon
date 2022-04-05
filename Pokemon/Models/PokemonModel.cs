namespace Pokemon.Models
{
    public class PokemonModel
    {
        public int Height { get; set; }
        public int Id { get; set; }
        public bool Is_default { get; set; }
        public string? location_area_encounters { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public int Weight { get; set; }
    }

    public class Species
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Sprites
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }

    }



}
