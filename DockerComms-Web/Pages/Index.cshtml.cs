using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DockerComms_Web.Pages
{
    public class IndexModel : PageModel
    {
        private static Proxy _proxy = new Proxy();

        public string Message { get; private set; }
        public async Task OnGetAsync()
        {
            var result = await _proxy.MakeApiCallAsync();
            Message = result;
        }
    }
}
