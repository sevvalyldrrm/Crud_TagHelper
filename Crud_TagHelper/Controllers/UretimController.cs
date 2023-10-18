using Crud_TagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crud_TagHelper.Controllers
{
	public class UretimController : Controller
	{
		List<Models.Makine> data = new List<Models.Makine>() {
				new Models.Makine {Id = 1, Tanim="10n Kaynak Punta" , Aciklama="Açıklama 1", UretimSurecId=1},
				new Models.Makine {Id = 2, Tanim="800ton Pres" , Aciklama="Açıklama 2", UretimSurecId=2},
				new Models.Makine {Id = 3, Tanim="Çift Renk Boya Hub" , Aciklama="Açıklama 3", UretimSurecId=3},
				};

		List<Models.UretimSurec> surecData = new List<UretimSurec>()
		{
			new UretimSurec {Id = 1, Tanim="Makine Bazında", Aciklama="Açıklama 1"},
			new UretimSurec {Id = 2, Tanim="Personel Bazında", Aciklama="Açıklama 2"},
			new UretimSurec {Id = 3, Tanim="Baz Bazında", Aciklama="Açıklama 3"},
			new UretimSurec {Id = 4, Tanim="Fason Bazında", Aciklama="Açıklama 4"},
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


			//UretimSurec model datası liste şeklinden View'e gönderilecek
			//Select

			ViewData["UretimSurec"] = new SelectList(surecData, "Id", "Tanim");



			return View(makineSatiri);
		}


		[HttpPost]
		public IActionResult Duzenle(Makine model)
		{
			var degisenData = data.Find(t => t.Id == model.Id);
            if (degisenData == null)
            {
				return RedirectToAction(nameof(Index));
            }
			degisenData.Tanim = model.Tanim;
			degisenData.Aciklama = model.Aciklama;

			return RedirectToAction(nameof(Index));
		}
	}
}
