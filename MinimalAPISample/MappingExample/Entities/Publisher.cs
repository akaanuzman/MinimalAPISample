namespace MinimalAPISample.MappingExample.Entities;

public class Publisher
{
    public required string Id { get; init; }
    public required string Email { get; init; }
    public required string Name { get; init; }
    public required string Role { get; init; }
    public required List<BlogPost> BlogPosts { get; init; } = [];
}