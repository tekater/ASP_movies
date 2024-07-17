using ASP_Movie.Cinema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Movie.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
        private readonly Seans _seans;
        public IndexModel(Seans seans)
        {
            _seans = seans;
        }
        public List<Movie> Movie { get; set; }
        public void OnGet()
		{
            Movie = _seans.GetMovie();
        }
	}
}
