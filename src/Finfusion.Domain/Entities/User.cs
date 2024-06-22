using Finfusion.Domain.Core.Abstractions;
using Finfusion.Domain.Core.Errors;
using Finfusion.Domain.Core.Primitives;
using Finfusion.Domain.Core.Primitives.Result;
using Finfusion.Domain.Core.Utility;
using Finfusion.Domain.Events;
using Finfusion.Domain.Services;
using Finfusion.Domain.ValueObjects;


namespace Finfusion.Domain.Entities;

/// <summary>
/// Represents the user entity.
/// </summary>
public sealed class User : AggregateRoot, IAuditableEntity, ISoftDeletableEntity
{
  private string _passwordHash;

  /// <summary>
  /// Initializes a new instance of the <see cref="User"/> class.
  /// </summary>
  /// <param name="firstName">The user first name.</param>
  /// <param name="lastName">The user last name.</param>
  /// <param name="email">The user email instance.</param>
  /// <param name="passwordHash">The user password hash.</param>
  private User(FirstName firstName, LastName lastName, Email email, string passwordHash)
      : base(Ulid.NewUlid())
  {
    Ensure.NotEmpty(firstName, "The first name is required.", nameof(firstName));
    Ensure.NotEmpty(lastName, "The last name is required.", nameof(lastName));
    Ensure.NotEmpty(email, "The email is required.", nameof(email));
    Ensure.NotEmpty(passwordHash, "The password hash is required", nameof(passwordHash));

    FirstName = firstName;
    LastName = lastName;
    Email = email;
    _passwordHash = passwordHash;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="User"/> class.
  /// </summary>
  /// <remarks>
  /// Required by EF Core.
  /// </remarks>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
  private User()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
  {
  }

  /// <summary>
  /// Gets the user first name.
  /// </summary>
  public FirstName FirstName { get; private set; }

  /// <summary>
  /// Gets the user last name.
  /// </summary>
  public LastName LastName { get; private set; }

  /// <summary>
  /// Gets the user full name.
  /// </summary>
  public string FullName => $"{FirstName} {LastName}";

  /// <summary>
  /// Gets the user email.
  /// </summary>
  public Email Email { get; private set; }

  /// <inheritdoc />
  public DateTimeOffset CreatedOnUtc { get; }

  /// <inheritdoc />
  public DateTimeOffset? ModifiedOnUtc { get; }

  /// <inheritdoc />
  public DateTimeOffset? DeletedOnUtc { get; }

  /// <inheritdoc />
  public bool Deleted { get; }

  /// <summary>
  /// Creates a new user with the specified first name, last name, email and password hash.
  /// </summary>
  /// <param name="firstName">The first name.</param>
  /// <param name="lastName">The last name.</param>
  /// <param name="email">The email.</param>
  /// <param name="passwordHash">The password hash.</param>
  /// <returns>The newly created user instance.</returns>
  public static User Create(FirstName firstName, LastName lastName, Email email, string passwordHash)
  {
    var user = new User(firstName, lastName, email, passwordHash);

    user.AddDomainEvent(new UserCreatedDomainEvent(user));

    return user;
  }



  /// <summary>
  /// Verifies that the provided password hash matches the password hash.
  /// </summary>
  /// <param name="password">The password to be checked against the user password hash.</param>
  /// <param name="passwordHashChecker">The password hash checker.</param>
  /// <returns>True if the password hashes match, otherwise false.</returns>
  public bool VerifyPasswordHash(string password, IPasswordHashChecker passwordHashChecker)
      => !string.IsNullOrWhiteSpace(password) && passwordHashChecker.HashesMatch(_passwordHash, password);

  /// <summary>
  /// Changes the users password.
  /// </summary>
  /// <param name="passwordHash">The password hash of the new password.</param>
  /// <returns>The success result or an error.</returns>
  public Result ChangePassword(string passwordHash)
  {
    if (passwordHash == _passwordHash)
    {
      return Result.Failure(DomainErrors.User.CannotChangePassword);
    }

    _passwordHash = passwordHash;

    AddDomainEvent(new UserPasswordChangedDomainEvent(this));

    return Result.Success();
  }

  /// <summary>
  /// Changes the users first and last name.
  /// </summary>
  /// <param name="firstName">The new first name.</param>
  /// <param name="lastName">The new last name.</param>
  public void ChangeName(FirstName firstName, LastName lastName)
  {
    Ensure.NotEmpty(firstName, "The first name is required.", nameof(firstName));
    Ensure.NotEmpty(lastName, "The last name is required.", nameof(lastName));

    FirstName = firstName;

    LastName = lastName;

    AddDomainEvent(new UserNameChangedDomainEvent(this));
  }

}

