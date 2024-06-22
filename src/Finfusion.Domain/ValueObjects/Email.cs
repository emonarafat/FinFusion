
using Finfusion.Domain.Core.Errors;

using Finfusion.Domain.Core.Primitives;
using Finfusion.Domain.Core.Primitives.Result;
using Finfusion.Domain.Core.Utility;

using System.Text.RegularExpressions;

namespace Finfusion.Domain.ValueObjects;

/// <summary>
/// Represents the email value object.
/// </summary>
public sealed partial class Email : ValueObject
{
  /// <summary>
  /// The email maximum length.
  /// </summary>
  public const int MaxLength = 256;


  private static readonly Lazy<Regex> _emailFormatRegex =
      new(GeneratedRegex.EmailRegex);

  /// <summary>
  /// Initializes a new instance of the <see cref="Email"/> class.
  /// </summary>
  /// <param name="value">The email value.</param>
  private Email(string value)
  {
    Value = value;
  }

  /// <summary>
  /// Gets the email value.
  /// </summary>
  public string Value { get; }

  /// <summary>
  /// Email to string.
  /// </summary>
  /// <param name="email"></param>
  public static implicit operator string(Email email) => email.Value;

  /// <summary>
  /// Creates a new <see cref="Email"/> instance based on the specified value.
  /// </summary>
  /// <param name="email">The email value.</param>
  /// <returns>The result of the email creation process containing the email or an error.</returns>
  public static Result<Email> Create(string email) =>
      Result.Create(email, DomainErrors.Email.NullOrEmpty)
          .Ensure(e => !string.IsNullOrWhiteSpace(e), DomainErrors.Email.NullOrEmpty)
          .Ensure(e => e.Length <= MaxLength, DomainErrors.Email.LongerThanAllowed)
          .Ensure(e => _emailFormatRegex.Value.IsMatch(e), DomainErrors.Email.InvalidFormat)
          .Map(e => new Email(e));

  /// <inheritdoc />
  protected override IEnumerable<object> GetAtomicValues()
  {
    yield return Value;
  }


}
