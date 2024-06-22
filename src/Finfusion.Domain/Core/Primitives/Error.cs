namespace Finfusion.Domain.Core.Primitives;

/// <summary>
/// Represents a concrete domain error.
/// </summary>
/// <param name="code">The code.</param>
/// <param name="message">The message.</param>
/// <remarks>
/// Initializes a new instance of the <see cref="Error"/> class.
/// </remarks>
public sealed class Error(string code, string message) : ValueObject
{

  /// <summary>
  /// Gets the error code.
  /// </summary>
  public string Code { get; } = code;

  /// <summary>
  /// Gets the error message.
  /// </summary>
  public string Message { get; } = message;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator string(Error error) => error?.Code ?? string.Empty;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <inheritdoc />
  protected override IEnumerable<object> GetAtomicValues()
  {
    yield return Code;
    yield return Message;
  }

  /// <summary>
  /// Gets the empty error instance.
  /// </summary>
  internal static Error None => new(string.Empty, string.Empty);
}
