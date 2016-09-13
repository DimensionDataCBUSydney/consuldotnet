using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consul.Models
{
	public class CatalogService
	{
		public string Node { get; set; }
		public string Address { get; set; }
		public string ServiceID { get; set; }
		public string ServiceName { get; set; }
		public string ServiceAddress { get; set; }
		public string[] ServiceTags { get; set; }
		public int ServicePort { get; set; }
		public bool ServiceEnableTagOverride { get; set; }
	}
}
