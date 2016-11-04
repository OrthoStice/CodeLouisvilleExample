using System;
using System.Collections.Generic;
using System.Web.Mvc;
using GameExampleMVC.Models;

namespace GameExampleMVC.Controllers
{
    public class HomeController : Controller
    {
		[HttpGet]
        public ActionResult Index()
        {
			var model = new GameStartViewModel {GameId = Guid.NewGuid()};
            return View(model);
        }

		[HttpPost]
        public ActionResult Index(GameStartViewModel model)
		{
			if(!ModelState.IsValid)
				return View(model);
			//TODO Save the game to a database
			return RedirectToAction("PlacePieces", new {id = model.GameId});
		}

		[HttpGet]
	    public ActionResult PlacePieces(Guid id)
	    {
			//TODO Load the game from the database to make sure it is a real game and ready to place pieces
			var model = new PlacePiecesViewModel
			{
				GameId = id,
				//For this example I am only using one piece
				Pieces = new List<PieceViewModel>
				{
					new PieceViewModel()
				}
			};
		    return View(model);
	    }

	    [HttpPost]
	    public ActionResult PlacePieces(PlacePiecesViewModel model)
	    {
		    if(!ModelState.IsValid)
				return View(model);

			return RedirectToAction("PlayGame", new {id = model.GameId});
	    }

	    [HttpGet]
	    public ActionResult PlayGame(Guid id)
	    {
		    //TODO Make sure all of the game pieces have been placed, send back if not

		    return View();
	    }
    }
}