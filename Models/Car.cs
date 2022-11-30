namespace Gosha.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? Image { get; set; }
        public uint Price { get; set; }
        public bool? IsFavourite { get; set; }
        public bool? Available { get; set; }
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }
    }
}
