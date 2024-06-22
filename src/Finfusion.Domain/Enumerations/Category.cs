using Finfusion.Domain.Core.Primitives;

namespace Finfusion.Domain.Enumerations;

/// <summary>
/// Represents the category enumeration.
/// </summary>
public sealed class Category : Enumeration<Category>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static readonly Category None = new(0, "None");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static readonly Category Concert = new(1, "Concert");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Initializes a new instance of the <see cref="Category"/> class.
  /// </summary>
  /// <param name="value">The value.</param>
  /// <param name="name">The name.</param>
  private Category(int value, string name)
      : base(value, name)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Category"/> class.
  /// </summary>
  /// <param name="value">The value.</param>
  /// <remarks>
  /// Required by EF Core.
  /// </remarks>
  private Category(int value)
      : base(value, FromValue(value).Value.Name)
  {
  }
}
