using System;
using System.ComponentModel.DataAnnotations;

namespace GameExampleMVC.Models
{
	public class GameViewModelBase
	{
		[Required]
		public Guid? GameId { get; set; }
	}
}