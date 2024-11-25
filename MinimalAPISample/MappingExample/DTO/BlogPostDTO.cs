namespace MinimalAPISample.MappingExample.DTO;

public record BlogPostDTO
{
    public required string Url { get; init; }
    public required string Title { get; init; }
    public required string Content { get; init; }
    public required DateOnly PublishedUtc { get; init; }
    public required PublisherDTO Publisher { get; init; }
    public required double Rating { get; init; }
}