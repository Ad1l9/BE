using Be.Models.Base;

namespace Be.Models
{
    public class Position:BaseNameableEntity
    {
        public List<Employee>? Employees { get; set; }
    }
}
