using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazzarWebApp.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        
        public void OnGet()
        {

        }
    }
}
