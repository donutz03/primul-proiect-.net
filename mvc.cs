
using System.ComponentModel.DataAnnotations;
routes.MapRoute(name: "Default", template: "{controller=Home}/{action=Index}/{id?}");

[Route("api/[controller]")]
public class ProductsController : Controller 
{
    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        // ...
    }
}

// public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null) {
//     // ...
// }


public class LoginViewModel {
    [Required]
    [EmailAddress]
    public string Email {get; set;}

    [Display(nameof = "Remember me?")]
    public bool RememberMe {get;set;}

    public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null) 
{
    if (ModeLState.IsValid) {
        // work 
    }

    return View(model);
}
}



// @inject SomeService ServiceName
// <!DOCTYPE html>
// <html lang="en">
// <head>
//     <title>@ServiceName.GetTitle</title>
// </head>
//     <body>
//         <h1>@ServiceName.GetTitle</h1>
//     </body>
// </html>

[Authorize]
public class AccountController : Controller

<ul>
@for(int i=0;if<5;i++)
{
    <li>List item @i</li>
}
</ul>

