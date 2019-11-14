using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRelatoriosPDF.Models
{
	public class Pedido
	{
		public int PedidoId { get; set; }
		public int ClienteId { get; set; }
		public DateTime PedidoData { get; set; }
		public decimal PedidoTotal { get; set; }
	}
}