
using Finfusion.Domain.Core.Abstractions;
using Finfusion.Domain.Core.Errors;
using Finfusion.Domain.Core.Primitives;
using Finfusion.Domain.Core.Primitives.Result;
using Finfusion.Domain.Core.Utility;
using Finfusion.Domain.Enumerations;
using Finfusion.Domain.ValueObjects;

namespace Finfusion.Domain.Entities;

/// <summary>
/// Represents the base class that all events derive from.
/// </summary>
public abstract class Event : AggregateRoot, IAuditableEntity, ISoftDeletableEntity
{
  /// <summary>
  /// Initializes a new instance of the <see cref="Event"/> class.
  /// </summary>
  /// <param name="user">The user.</param>
  /// <param name="name">The event name.</param>
  /// <param name="category">The category.</param>
  /// <param name="dateTimeUtc">The date and time of the event in UTC format.</param>
  /// <param name="eventType">The event type.</param>
  protected Event(User user, Name name, Category category, DateTime dateTimeUtc, EventType eventType)
      : base(Ulid.NewUlid())
  {
    Ensure.NotNull(user, "The user is required.", nameof(user));
    Ensure.NotEmpty(user.Id, "The user identifier is required.", $"{nameof(user)}{nameof(user.Id)}");
    Ensure.NotNull(name, "The name is required.", nameof(name));
    Ensure.NotNull(category, "The category is required.", nameof(category));
    Ensure.NotEmpty(dateTimeUtc, "The date and time of the event is required.", nameof(dateTimeUtc));

    UserId = user.Id;
    Name = name;
    Category = category;
    DateTimeUtc = dateTimeUtc;
    EventType = eventType;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Event"/> class.
  /// </summary>
  /// <remarks>
  /// Required by EF Core.
  /// </remarks>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
  protected Event()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
  {
  }

  /// <summary>
  /// Gets the user identifier.
  /// </summary>
  public Ulid UserId { get; private set; }

  /// <summary>
  /// Gets the event name.
  /// </summary>
  public Name Name { get; private set; }

  /// <summary>
  /// Gets the category.
  /// </summary>
  public Category Category { get; private set; }

  /// <summary>
  /// Gets the date and time of the event in UTC format.
  /// </summary>
  public DateTime DateTimeUtc { get; private set; }

  /// <summary>
  /// Gets the value indicating whether or not the event has been cancelled.
  /// </summary>
  public bool Cancelled { get; private set; }

  /// <summary>
  /// Gets the event type.
  /// </summary>
  public EventType EventType { get; private set; }

  /// <inheritdoc />
  public DateTimeOffset CreatedOnUtc { get; }

  /// <inheritdoc />
  public DateTimeOffset? ModifiedOnUtc { get; }

  /// <inheritdoc />
  public DateTimeOffset? DeletedOnUtc { get; }

  /// <inheritdoc />
  public bool Deleted { get; }

  /// <summary>
  /// Cancels the event and returns the respective result.
  /// </summary>
  /// <param name="utcNow">The current date and time in UTC format.</param>
  /// <returns>The result of the operation.</returns>
  public virtual Result Cancel(DateTimeOffset utcNow)
  {
    if (Cancelled)
    {
      return Result.Failure(DomainErrors.Event.AlreadyCancelled);
    }

    if (utcNow > DateTimeUtc)
    {
      return Result.Failure(DomainErrors.Event.EventHasPassed);
    }

    Cancelled = true;

    return Result.Success();
  }

  /// <summary>
  /// Changes the event name and returns true if a change has occurred.
  /// </summary>
  /// <param name="name">The new event name.</param>
  /// <returns>True if the events name has changed, otherwise false.</returns>
  public virtual bool ChangeName(Name name)
  {
    if (name == Name)
    {
      return false;
    }

    Name = name;

    return true;
  }

  /// <summary>
  /// Changes the date and time to the specified value and returns true if a change has occurred.
  /// </summary>
  /// <param name="dateTimeUtc">The new event date and time.</param>
  /// <returns>True if the events date and time has changed, otherwise false.</returns>
  public virtual bool ChangeDateAndTime(DateTime dateTimeUtc)
  {
    if (dateTimeUtc == DateTimeUtc)
    {
      return false;
    }

    DateTimeUtc = dateTimeUtc;

    return true;
  }
}
