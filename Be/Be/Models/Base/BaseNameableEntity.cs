namespace Be.Models.Base
{
    public abstract class BaseNameableEntity:BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
