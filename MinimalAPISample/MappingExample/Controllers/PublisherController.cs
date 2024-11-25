namespace MinimalAPISample.MappingExample.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PublisherController : ControllerBase
{
    [HttpGet]
    public IActionResult GetPublishers()
    {
        // var publishers = await dbContext.Publishers
        //     .Include(b => b.BlogPosts)
        //     .ThenInclude(b => b.BlogHistoryRecords)
        //     .ToListAsync();
        //
        // var publisherDTOs = publishers
        //     .Select(x => x.MapToPublisherDto())
        //     .ToList();
        //
        // return Results.Ok(publisherDTOs);
        
        return Ok("GetPublishers");
    }
}