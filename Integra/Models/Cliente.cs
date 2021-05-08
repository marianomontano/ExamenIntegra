using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Integra.Models
{
	public class Cliente
	{
		public int Id { get; set; }

		[Required]
		[Range(20000000000, 33999999999, ErrorMessage = "Cuit fuera de rango, ingréselo nuevamente")]
		public long Cuit { get; set; }

		[Required]
		[Display(Name = "Razón Social")]
		public string RazonSocial { get; set; }

		[Required]
		[Display(Name = "Teléfono")]
		public long Telefono { get; set; }

		[Required]
		[Display(Name = "Dirección")]
		[MaxLength(200, ErrorMessage = "El domicilio puede tener 200 caracteres como máximo")]
		public string Direccion { get; set; }

		[Required]
		public bool Activo { get; set; }
	}
}