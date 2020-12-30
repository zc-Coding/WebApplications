using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureHost.Pages
{
    public class IndexModel : PageModel
    {
        public string Time { get; set; }

        public void OnGet()
        {
            Time = DateTime.Now.ToLocalTime().ToShortTimeString();
        }
    }
}
