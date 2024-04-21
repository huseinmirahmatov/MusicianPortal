namespace Domain.Entities
{
    public class Listener: BaseEntity
    {
       
        public User Users { get; set; }
        public int UserId { get; set; }
        public Track Tracks { get; set; }
        public int TrackId { get; set; }
        public PlayList PlayLists { get; set; }
        public int PlaylistId { get; set; }
    }
}
