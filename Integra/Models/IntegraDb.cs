using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Integra.Models
{
	public class IntegraDb : DbContext
	{
		public IntegraDb() : base("Data Source=.;Initial Catalog=IntegraComex;Integrated Security=True")
		{ 
		}

		public virtual DbSet<Cliente> Clientes { get; set; }
	}
}