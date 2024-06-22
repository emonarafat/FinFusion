using Finfusion.Domain.Core.Primitives;

namespace Finfusion.Domain.Core.Exceptions;

/// <summary>
/// Represents an exception that occurred in the domain.
/// </summary>
/// <param name="error">The error.</param>
/// <remarks>
/// Initializes a new instance of the <see cref="DomainException"/> class.
/// </remarks>
public class DomainException(Error error) : Exception(error.Message)
{

  /// <summary>
  /// Gets the error.
  /// </summary>
  public Error Error { get; } = error;
}
