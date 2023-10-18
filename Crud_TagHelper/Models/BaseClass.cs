using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_TagHelper.Models
{
	public class BaseClass
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[DisplayName("Tanım X")]
		[Required(ErrorMessage = "{0} alanı boş geçilmez")]
		[StringLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		[MinLength(3,ErrorMessage= "{0} alanı en az {1} karakter olabilir")]
		public string Tanim { get; set; }

		public string Aciklama { get; set; }

		public bool Aktif { get; set; } = true;

		public string AktifString => Aktif ? "Aktif" : "Pasif";


	}
}
