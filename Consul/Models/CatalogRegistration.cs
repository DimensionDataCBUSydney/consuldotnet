using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consul.Models
{
	/// <summary>
	/// Catalog Registration node
	/// </summary>
	public class CatalogRegistration
	{
		public string Node { get; set; }
		public string Address { get; set; }
		public string Datacenter { get; set; }
		public AgentService Service { get; set; }
		public AgentCheck Check { get; set; }
	}
}
