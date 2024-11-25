namespace MinimalAPISample.MappingExample.Entities;

public class BlogPost
{
    public required string Id { get; init; }
    public required string Title { get; init; }
    public required string Content { get; init; }
    public required DateTime PublishedUtc { get; set; }
    public required string PublisherId { get; init; }
    public required Publisher Publisher { get; set; }
    public required List<BlogHistoryRecord> BlogHistoryRecords { get; init; } = [];
}