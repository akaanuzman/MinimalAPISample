using MinimalAPISample.MappingExample.Database;
using MinimalAPISample.MappingExample.Entities;
using MongoDB.Driver;

namespace MinimalAPISample.MappingExample.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class BlogController : ControllerBase
{
    
    private readonly MongoDBConnection _mongoDBConnection;
    
    public BlogController(MongoDBConnection mongoDBConnection)
    {
        _mongoDBConnection = mongoDBConnection;
    }
    
    [HttpGet]
    public IActionResult GetBlogs()
    {
        var collection = _mongoDBConnection.GetCollection<BlogPost>("BlogPosts");
        var blogPosts = collection.Find(x => true).ToList();
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