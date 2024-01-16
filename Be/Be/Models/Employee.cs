using Be.Models.Base;

namespace Be.Models
{
    public class Employee:BaseNameableEntity
    {
        public string ImageUrl { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
