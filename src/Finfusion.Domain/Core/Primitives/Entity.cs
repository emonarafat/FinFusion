using Finfusion.Domain.Core.Utility;

namespace Finfusion.Domain.Core.Primitives;

/// <summary>
/// Represents the base class that all entities derive from.
/// </summary>
public abstract class Entity : IEquatable<Entity>
{
  /// <summary>
  /// Initializes a new instance of the <see cref="Entity"/> class.
  /// </summary>
  /// <param name="id">The entity identifier.</param>
  protected Entity(Guid id)
      : this()
  {
    Ensure.NotEmpty(id, "The identifier is required.", nameof(id));

    Id = id;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Entity"/> class.
  /// </summary>
  /// <remarks>
  /// Required by EF Core.
  /// </remarks>
  protected Entity()
  {
  }

  /// <summary>
  /// Gets or sets the entity identifier.
  /// </summary>
  public Guid Id { get; private set; }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="a"></param>
  /// <param name="b"></param>
  /// <returns></returns>
  public static bool operator ==(Entity a, Entity b)
  {
    if (a is null && b is null)
    {
      return true;
    }

    if (a is null || b is null)
    {
      return false;
    }

    return a.Equals(b);
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="a"></param>
  /// <param name="b"></param>
  /// <returns></returns>
  public static bool operator !=(Entity a, Entity b) => !(a == b);

  /// <summary>
  /// TODO: Add Summary.
  /// </summary>
  /// <param name="other">The other.</param>
  /// <returns>A <see cref="bool"/></returns>
  public bool Equals(Entity? other)
  {
    if (other is null)
    {
      return false;
    }

    return ReferenceEquals(this, other) || Id == other.Id;
  }

  /// <summary>
  /// TODO: Add Summary.
  /// </summary>
  /// <param name="obj">The obj.</param>
  /// <returns>A <see cref="bool"/></returns>
  public override bool Equals(object? obj)
  {
    if (obj is null)
    {
      return false;
    }

    if (ReferenceEquals(this, obj))
    {
      return true;
    }

    if (obj.GetType() != GetType())
    {
      return false;
    }

    if (obj is not Entity other)
    {
      return false;
    }

    if (Id == Guid.Empty || other.Id == Guid.Empty)
    {
      return false;
    }

    return Id == other.Id;
  }

  /// <summary>
  /// Get hash code.
  /// </summary>
  /// <returns>An <see cref="int"/></returns>
  public override int GetHashCode() => Id.GetHashCode() * 41;
}
