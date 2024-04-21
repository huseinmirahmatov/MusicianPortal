namespace Domain.Entities
{
    public class PlayList: BaseEntity
    {
       
        public string Title { get; set; }
        public Track Tracks { get; set; }
        public string TrackId { get; set; }
        public virtual ICollection<Listener> listeners { get; set; }
    }
}
