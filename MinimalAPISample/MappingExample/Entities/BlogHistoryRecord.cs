namespace MinimalAPISample.MappingExample.Entities;

public class BlogHistoryRecord
{
    public required string Id { get; init; }
    public required string BlogPostId { get; init; }
    public required BlogPost BlogPost { get; init; }
    public required DateTime Date { get; init; }
    public required double Rating { get; init; }
}