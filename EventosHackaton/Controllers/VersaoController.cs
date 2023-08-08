using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace EventosHackaton.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class VersaoController : ControllerBase
	{
		[HttpGet]
		public string Get() => Assembly.GetExecutingAssembly().GetName().Version?.ToString();
	}	
}
