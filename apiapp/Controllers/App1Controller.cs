using System;
using System.Diagnostics.Contracts;
using System.Web.Http;

namespace JenCompany.Sun.Controllers
{
	public class App1Controller : ApiController
	{
		[HttpGet]
		[Route("api/App1")]
		public String Get()
		{
			Contract.Ensures(Contract.Result<String>() != null);

			return "Hello API App!";
		}
	}
}
