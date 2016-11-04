using System;
using System.ComponentModel.DataAnnotations;

namespace GameExampleMVC.Models
{
	public class GameStartViewModel:GameViewModelBase
	{
		[Required]
		[StringLength(20)]
		public string GameName { get; set; }
	}
}