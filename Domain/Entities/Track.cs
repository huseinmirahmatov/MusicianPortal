using Domain.Enum;

namespace Domain.Entities
{
    public class Track: BaseEntity
    {
  
        public string Title { get; set; }
        public Artist Artists { get; set; }
        public int ArtistId { get; set; }
        public string Duration { get; set; }
        public Album Albums { get; set; }
        public int AlbumId { get; set; }
        public Rating Rating { get;set; }
        public Genre Genres { get; set; }
        public int GenreId { get; set; }
        public string Reveiew { get; set;}
        public virtual ICollection<Listener> listeners { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
    }
}
