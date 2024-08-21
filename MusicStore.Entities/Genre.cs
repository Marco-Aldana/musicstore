namespace MusicStore.Entities;

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public bool Status { get; set; } = true;
    }
