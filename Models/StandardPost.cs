using Piranha.AttributeBuilder;
using Piranha.Models;

namespace piranhademo.Models;

[PostType(Title = "Standard post")]
public class StandardPost  : Post<StandardPost>
{
}
