using MVCRelatoriosPDF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRelatoriosPDF.DB
{
	public static class SimulacaoDB
	{
		public static List<Cliente> GetAllClientes()
		{
			var listaRetorno = new List<Cliente>()
			{
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				},
				new Cliente ()
				{
					ClienteId = 1,
					Email = "Vítor Nicacio dos Santos",
					Endereco = "Bahia minha alegria",
					Nome = "Vitor",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 1,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 2,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 3,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "35353535"
				},
				new Cliente ()
				{
					ClienteId = 2,
					Email = "Jonas Brother",
					Endereco = "Rio de janeiro cidade Maravilhosa",
					Nome = "Jonas",
					Pedidos = new List<Pedido>()
					{
						new Pedido()
						{
							ClienteId = 3,
							PedidoId = 4,
							PedidoData = DateTime.Now,
							PedidoTotal = 2500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 5,
							PedidoData = DateTime.Now,
							PedidoTotal = 4500
						},
						new Pedido()
						{
							ClienteId = 1,
							PedidoId = 6,
							PedidoData = DateTime.Now,
							PedidoTotal = 5500
						}
					},
					Telefone = "353535235"
				}
			};
			return listaRetorno;
		}

	}
}