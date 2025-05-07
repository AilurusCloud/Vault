namespace Ailurus.Kms.Domain.Entities;

public sealed class Client
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Name { get; init; }
    public required string ClientId { get; init; }
    public required string ClientSecretHash { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}