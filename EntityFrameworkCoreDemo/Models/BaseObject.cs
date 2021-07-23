using System;

namespace EntityFrameworkCoreDemo.Models
{
    public class BaseObject
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return $"Id -> {Id}";
        }
    }
}
