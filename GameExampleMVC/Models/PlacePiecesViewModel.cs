using System.Collections.Generic;
using System.Drawing;

namespace GameExampleMVC.Models
{
	public class PlacePiecesViewModel:GameViewModelBase
	{
		public List<PieceViewModel> Pieces { get; set; }
	}
}