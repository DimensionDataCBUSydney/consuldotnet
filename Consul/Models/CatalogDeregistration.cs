using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consul.Models
{
	public class CatalogDeregistration
	{
		public string Node { get; set; }
		public string Address { get; set; }
		public string Datacenter { get; set; }
		public string ServiceID { get; set; }
		public string CheckID { get; set; }
	}
}
