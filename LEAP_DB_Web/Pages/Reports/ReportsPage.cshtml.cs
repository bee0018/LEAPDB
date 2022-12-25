using LEAP_DB_Web.Pages.Reports.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LEAP_DB_Web.Pages.Reports
{
    public class ReportsPageModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            StudentPDFGenerator.GenerateStudentReport();
        }
    }
}
