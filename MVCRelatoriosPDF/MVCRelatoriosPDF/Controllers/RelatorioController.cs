using MVCRelatoriosPDF.DB;
using PagedList;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRelatoriosPDF.Controllers
{
	/// <summary>
	/// Relatório utilizando a bibliotecas Rotativa e PagedList.MVC Necessario instalar nuget>
	/// necessário instalar o pacote Install-Package Rotativa -Version 1.7.4-rc  para não ter problemas com dll
	/// </summary>
	public class RelatorioController : Controller
    {
        // GET: Relatorio
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult RelatorioCliente(int? pagina, Boolean? pdf)
		{
			var listaClientes = SimulacaoDB.GetAllClientes();
			if (pdf != true)
			{
				int numeroRegistros = 3;
				int numeroPagina = (pagina ?? 1);
				return View(listaClientes.ToPagedList(numeroPagina, numeroRegistros));
			}
			else
			{
				int pagNumero = 1;

				var relatorioPDF = new Rotativa.ViewAsPdf
				{
					ViewName = "_Relatorio",
					IsGrayScale = true,
					Model = listaClientes.ToPagedList(pagNumero, listaClientes.Count)
				};
				return relatorioPDF;
			}
		}
    }
}