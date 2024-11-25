namespace MinimalAPISample.MappingExample.DTO;

public record PublisherDTO
{
    public required string Name { get; init; }
    public required int TotalPosts { get; init; }
    public required double Rating { get; init; }
}