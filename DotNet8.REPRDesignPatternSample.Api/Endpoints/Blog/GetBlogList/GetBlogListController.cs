using DotNet8.REPRDesignPatternSample.DbService.AppDbContexts;
using DotNet8.REPRDesignPatternSample.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.REPRDesignPatternSample.Api.Endpoints.Blog.GetBlogList;

[Route("api/[controller]")]
[ApiController]
public class GetBlogListController : ControllerBase
{
    private readonly AppDbContext _context;

    public GetBlogListController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetBlogs()
    {
        var dataLst = await _context.Blogs.OrderByDescending(x => x.BlogId).ToListAsync();
        var lst = dataLst.Select(x => x.Change()).ToList();
        var model = new GetBlogListResponse { DataLst = lst };

        return Ok(model);
    }
}
