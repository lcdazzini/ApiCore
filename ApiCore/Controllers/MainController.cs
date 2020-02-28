using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Controllers
{
	[ApiController]
	public class MainController : ControllerBase
	{
		public ActionResult CustomResponse(object result = null)
		{
			if (OperacaoValida())
			{
				return Ok(new
				{
					success = true,
					data = result
				});
			}

			return BadRequest(new { 
				success = false,
				errors = ObterErros()
			});
		}

		public bool OperacaoValida()
		{
			return true;
		}

		protected string ObterErros()
		{
			return "";
		}
	}
}