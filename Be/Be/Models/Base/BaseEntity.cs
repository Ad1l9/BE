namespace Be.Models.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public BaseEntity()
        {
            CreatedAt= DateTime.Now;
        }
    }
}
