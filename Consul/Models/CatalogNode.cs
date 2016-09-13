using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consul.Models
{
	public class CatalogNode
	{
		public Node Node { get; set; }
		public Dictionary<string, AgentService> Services { get; set; }

		public CatalogNode()
		{
			Services = new Dictionary<string, AgentService>();
		}
	}
}
