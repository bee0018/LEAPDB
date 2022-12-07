using LEAP_DB_Web.Pages.Login.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LEAP_DB_Web.Pages.Login
{
    public class ContactPageModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            // Gathers the fields on Post
            var toAddress = Request.Form["emailAddress"];
            var subject = Request.Form["subject"];
            var message = Request.Form["message"];

            // Sends the email to the user
            EmailUtil.SendEmail(toAddress, subject, message);

        }
    }
}
