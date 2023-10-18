using Crud_TagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crud_TagHelper.Controllers
{
	public class UretimController : Controller
	{
		List<Models.Makine> data = new List<Models.Makine>() {
				new Models.Makine {Id = 1, Tanim="10n Kaynak Punta" , Aciklama="Açıklama 1"},
				new Models.Makine {Id = 2, Tanim="800ton Pres" , Aciklama="Açıklama 2"},
				new Models.Makine {Id = 3, Tanim="Çift Renk Boya Hub" , Aciklama="Açıklama 3"},
				};
		public IActionResult Index()
		{
			return View(data);
		}


		public IActionResult Duzenle(int? id)
		{
			if(id is null)
			{
				return RedirectToAction(nameof(Index));
			}

			//data.Where(t => t.Id == id).FirstOrDefault();
			//data.FirstOrDefault(t => t.Id == id);
			var makineSatiri = data.Find(x => x.Id == id);

			if (makineSatiri == null)
			{
				return RedirectToAction(nameof(Index));
			}

			return View(makineSatiri);
		}


		[HttpPost]
		public IActionResult Duzenle()
		{
			return View();
		}
	}
}
