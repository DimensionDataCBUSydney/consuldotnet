using Newtonsoft.Json;

namespace Consul.Models
{
	public class Node
	{
		// Cannot be "Node" as in the Go API because in C#, properties cannot
		// have the same name as their enclosing class.
		[JsonProperty(PropertyName = "Node")]
		public string Name { get; set; }
		public string Address { get; set; }
	}
}
