using MinimalAPISample.MappingExample.DTO;
using MinimalAPISample.MappingExample.Entities;

namespace MinimalAPISample.MappingExample.Extensions;

public static class BlogPostMappingExtensions
{
    public static BlogPostDTO MapToBlogPostDTO(this BlogPost entity)
    {
        return new BlogPostDTO
        {
            Url = entity.Id.ToString(),
            Title = entity.Title,
            Content = entity.Content,
            PublishedUtc = DateOnly.FromDateTime(entity.PublishedUtc),
            Publisher = entity.Publisher.MapToPublisherDTO(),
            Rating = entity.BlogHistoryRecords.Average(x => x.Rating)
        };
    }
    
    public static PublisherDTO MapToPublisherDTO(this Publisher entity)
    {
       var blogPostRatings = entity.BlogPosts
           .SelectMany(x => x.BlogHistoryRecords)
           .Select(x => x.Rating)
           .ToList();
       
       var averageRating = Math.Round(blogPostRatings.Average(), 2);
       
       return new PublisherDTO 
       {
           Name = entity.Name,
           TotalPosts = entity.BlogPosts.Count,
           Rating = averageRating    
       };
    }
    
    private static double CalculateRating(List<BlogHistoryRecord> historyRecords)
    {
        return Math.Round(historyRecords.Average(x => x.Rating), 2);
    }
}