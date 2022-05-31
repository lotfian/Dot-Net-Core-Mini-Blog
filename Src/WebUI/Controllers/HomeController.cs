namespace WebUI.Controllers;
public class HomeController : BaseController
{
    public HomeController(BlogContext context) : base(context)
    {
    }
    public async Task<IActionResult> Index()
    {
        var BlogList = await context.Posts.AsNoTracking().OrderByDescending(x=>x.Id).ToListAsync();
        //Get All Blog Category
        ViewBag.BlogCategory = context.Categories.AsNoTracking().ToList();
        //Get Recent Post in blog
        ViewBag.RecentPost = context.Posts.AsNoTracking().OrderByDescending(x => x.Id).Take(3).ToList();
        return View(BlogList);
    }
    [Route("Blog/{id}")]
    public async Task<IActionResult> BlogDetails(int id)
    {
        var BlogDetail = await context.Posts.FindAsync(id);
        if (BlogDetail == null)
            return NotFound();
        ViewData["Title"] = BlogDetail.Title != null ? BlogDetail.Title : string.Empty;
        //Get All Blog Category
        ViewBag.BlogCategory = context.Categories.AsNoTracking().ToList();
        //Get Recent Post in blog
        ViewBag.RecentPost = context.Posts.AsNoTracking().OrderByDescending(x => x.Id).Take(3).ToList();
        return View(BlogDetail);
    }
}
