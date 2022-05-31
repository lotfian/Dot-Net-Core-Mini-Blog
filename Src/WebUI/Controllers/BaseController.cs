namespace WebUI.Controllers;
public class BaseController : Controller
{
    public readonly BlogContext context;
    public BaseController(BlogContext context)
    {
        this.context = context;
    }
  
}