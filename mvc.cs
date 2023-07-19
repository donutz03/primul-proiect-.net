routes.MapRoute(name: "Default", template: "{controller=Home}/{action=Index}/{id?}");

[Route("api/[controller]")]
public class ProductsController : Controller 
{
    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        ...
    }
}