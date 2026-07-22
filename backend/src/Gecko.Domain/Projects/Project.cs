namespace Gecko.Domain.Projects;

public sealed class Project
{
    public Project(
        Guid id,
        Guid creatorId,
        string name,
        string? description,
        string repositoryUrl,
        DateTimeOffset createdAt)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("Project ID cannot be empty.", nameof(id));
        }

        if (creatorId == Guid.Empty)
        {
            throw new ArgumentException("Creator ID cannot be empty.", nameof(creatorId));
        }

        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        if (string.IsNullOrWhiteSpace(repositoryUrl)
            || !Uri.TryCreate(repositoryUrl.Trim(), UriKind.Absolute, out var uri)
            || uri.Scheme != Uri.UriSchemeHttps)
        {
            throw new ArgumentException(
                "Repository URL must be an absolute HTTPS URL.",
                nameof(repositoryUrl));
        }

        if (createdAt == default)
        {
            throw new ArgumentException("Creation date cannot be empty.", nameof(createdAt));
        }

        Id = id;
        CreatorId = creatorId;
        Name = name.Trim();
        Description = string.IsNullOrWhiteSpace(description) ? null : description.Trim();
        RepositoryUrl = repositoryUrl.Trim();
        CreatedAt = createdAt;
    }

    public Guid Id { get; }
    public Guid CreatorId { get; }
    public string Name { get; private set; }
    public string? Description { get; }
    public string RepositoryUrl { get; }
    public DateTimeOffset CreatedAt { get; }
}
