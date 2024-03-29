using Microsoft.AspNetCore.Authentication;

namespace Client.Pages.Account;

[Microsoft.AspNetCore.Authorization.Authorize]
public class LogoutModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public LogoutModel() : base()
	{
	}

	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> OnGetAsync()
	{
		// Part (2)
		// using Microsoft.AspNetCore.Authentication;
		await HttpContext.SignOutAsync();

		// Part (3)
		//// using Microsoft.AspNetCore.Authentication;
		//await HttpContext.SignOutAsync(scheme:
		//	Infrastructure.Security.Constants.DefaultScheme);

		return RedirectToPage(pageName: "/Index");
	}
}
