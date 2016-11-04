
using System.ComponentModel.DataAnnotations;

namespace GameExampleMVC.Models
{
	public class PieceViewModel
	{
		[Required]
		[Range(1, 10)]
		public int? X { get; set; }

		[Required]
		[Range(1, 10)]
		public int? Y { get; set; }

		//TODO Other data like the piece type, how log it is etc
	}
}