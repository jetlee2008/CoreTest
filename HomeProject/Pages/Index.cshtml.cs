using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HomeProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly string machineName;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            machineName = Environment.MachineName;
        }

        public void OnGet()
        {

        }
    }
}
