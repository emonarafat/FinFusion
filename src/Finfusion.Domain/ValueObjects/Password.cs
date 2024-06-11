using Finfusion.Domain.Core.Errors;
using Finfusion.Domain.Core.Primitives;
using Finfusion.Domain.Core.Primitives.Result;

namespace Finfusion.Domain.ValueObjects;

/// <summary>
/// Represents the password value object.
/// </summary>
public sealed class Password : ValueObject
{
  private const int MinPasswordLength = 6;
  private static readonly Func<char, bool> _isLower = c => c is >= 'a' and <= 'z';
  private static readonly Func<char, bool> _isUpper = c => c is >= 'A' and <= 'Z';
  private static readonly Func<char, bool> _isDigit = c => c is >= '0' and <= '9';
  private static readonly Func<char, bool> _isNonAlphaNumeric = c => !(_isLower(c) || _isUpper(c) || _isDigit(c));

  /// <summary>
  /// Initializes a new instance of the <see cref="Password"/> class.
  /// </summary>
  /// <param name="value">The password value.</param>
  private Password(string value) => Value = value;

  /// <summary>
  /// Gets the password value.
  /// </summary>
  public string Value { get; }

  /// <summary>
  /// Password to string.
  /// </summary>
  /// <param name="password"></param>
  public static implicit operator string(Password password) => password?.Value ?? string.Empty;

  /// <summary>
  /// Creates a new <see cref="Password"/> instance based on the specified value.
  /// </summary>
  /// <param name="password">The password value.</param>
  /// <returns>The result of the password creation process containing the password or an error.</returns>
  public static Result<Password> Create(string password) => Result.Create(password, DomainErrors.Password.NullOrEmpty)
    .Ensure(p => !string.IsNullOrWhiteSpace(p), DomainErrors.Password.NullOrEmpty)
    .Ensure(p => p.Length >= MinPasswordLength, DomainErrors.Password.TooShort)
    .Ensure(p => p.Any(_isLower), DomainErrors.Password.MissingLowercaseLetter)
    .Ensure(p => p.Any(_isUpper), DomainErrors.Password.MissingUppercaseLetter)
    .Ensure(p => p.Any(_isDigit), DomainErrors.Password.MissingDigit)
    .Ensure(p => p.Any(_isNonAlphaNumeric), DomainErrors.Password.MissingNonAlphaNumeric)
    .Map(p => new Password(p));

  /// <inheritdoc/>
  protected override IEnumerable<object> GetAtomicValues() { yield return Value; }
}
