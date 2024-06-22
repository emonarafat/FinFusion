using Finfusion.Domain.Core.Errors;
using Finfusion.Domain.Core.Primitives;
using Finfusion.Domain.Core.Primitives.Result;

namespace Finfusion.Domain.ValueObjects;

/// <summary>
/// Represents the last name value object.
/// </summary>
public sealed class LastName : ValueObject
{
  /// <summary>
  /// The last name maximum length.
  /// </summary>
  public const int MaxLength = 100;

  /// <summary>
  /// Initializes a new instance of the <see cref="LastName"/> class.
  /// </summary>
  /// <param name="value">The last name value.</param>
  private LastName(string value)
  {
    Value = value;
  }

  /// <summary>
  /// Gets the last name value.
  /// </summary>
  public string Value { get; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator string(LastName lastName) => lastName.Value;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Creates a new <see cref="FirstName"/> instance based on the specified value.
  /// </summary>
  /// <param name="lastName">The last name value.</param>
  /// <returns>The result of the last name creation process containing the last name or an error.</returns>
  public static Result<LastName> Create(string lastName) =>
      Result.Create(lastName, DomainErrors.LastName.NullOrEmpty)
          .Ensure(l => !string.IsNullOrWhiteSpace(l), DomainErrors.LastName.NullOrEmpty)
          .Ensure(l => l.Length <= MaxLength, DomainErrors.LastName.LongerThanAllowed)
          .Map(l => new LastName(l));

  /// <inheritdoc />
  public override string ToString() => Value;

  /// <inheritdoc />
  protected override IEnumerable<object> GetAtomicValues()
  {
    yield return Value;
  }
}
