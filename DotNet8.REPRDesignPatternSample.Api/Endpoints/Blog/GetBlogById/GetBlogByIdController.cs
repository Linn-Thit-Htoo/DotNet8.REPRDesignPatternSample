using DotNet8.REPRDesignPatternSample.DbService.AppDbContexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.REPRDesignPatternSample.Api.Endpoints.Blog.GetBlogById
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetBlogByIdController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GetBlogByIdController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            try
            {
                var item = await _context.Blogs
                    .FirstOrDefaultAsync(x => x.BlogId == id);
                if (item is null)
                    return NotFound();

                return Ok(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
