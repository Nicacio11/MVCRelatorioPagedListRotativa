﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRelatoriosPDF.Models
{
	public class Cliente
	{
		public int ClienteId { get; set; }
		public string Nome { get; set; }
		public string Endereco { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public virtual ICollection<Pedido> Pedidos { get; set; }
		public Cliente()
		{
			Pedidos = new List<Pedido>();
		}
	}
}