namespace _2.Models
{
    public class Kategooriatabel
    {
        public int Id { get; set; }
        public string Kategoorianimetus { get; set; }

        // Navigation
        public ICollection<Toodetabel> Tooted { get; set; }
    }
}
