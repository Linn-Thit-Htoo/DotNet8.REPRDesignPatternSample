using DotNet8.REPRDesignPatternSample.DbService.AppDbContexts;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.REPRDesignPatternSample.Api.Endpoints.Blog.CreateBlog;

[Route("api/[controller]")]
[ApiController]
public class CreateBlogController : ControllerBase
{
    private readonly AppDbContext _context;

    public CreateBlogController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateBlog([FromBody] CreateBlogRequest request)
    {
        try
        {
            var model = new Tbl_Blog()
            {
                BlogTitle = request.BlogTitle,
                BlogAuthor = request.BlogAuthor,
                BlogContent = request.BlogContent
            };
            await _context.Blogs.AddAsync(model);
            int result = await _context.SaveChangesAsync();

            return result > 0
                ? StatusCode(201, "Creating Successful.")
                : BadRequest("Creating Fail.");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
