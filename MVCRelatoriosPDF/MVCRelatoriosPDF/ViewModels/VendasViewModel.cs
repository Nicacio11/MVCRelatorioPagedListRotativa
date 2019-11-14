using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRelatoriosPDF.ViewModels
{
	public class VendasViewModel
	{
		public string ClienteNome { get; set; }
		public string ClienteEmail { get; set; }
		public DateTime PedidoData { get; set; }
		public decimal PedidoTotal { get; set; }
	}
}