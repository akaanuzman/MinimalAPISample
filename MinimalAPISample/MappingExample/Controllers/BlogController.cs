namespace MinimalAPISample.MappingExample.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class BlogController : ControllerBase
{
    [HttpGet]
    public IActionResult GetBlogs()
    {
        // var blogPosts = await dbContext.BlogPosts
        //     .Include(b => b.Publisher)
        //     .Include(b => b.BlogHistoryRecords)
        //     .ToListAsync();
        //
        // var blogPostDTOs = blogPosts
        //     .Select(x => x.MapToBlogPostDto())
        //     .ToList();
        //
        // return Results.Ok(blogPostDTOs);
        
        return Ok("GetBlogs");
    }
}