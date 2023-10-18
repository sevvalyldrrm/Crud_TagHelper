using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crud_TagHelper.Models
{
	public class Makine : BaseClass
	{
		[DisplayName("Üretim Süreç")]
		[Required(ErrorMessage ="Üretim Süreç seçiniz.")]
		public int UretimSurecId { get; set; }

		public UretimSurec UretimSurec { get; set; }	


	}
}
