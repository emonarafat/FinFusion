using Finfusion.Domain.Core.Primitives;

namespace Finfusion.Domain.Core.Errors;

/// <summary>
/// Contains the domain errors.
/// </summary>
public static class DomainErrors
{
  /// <summary>
  /// Contains the user errors.
  /// </summary>
  public static class User
  {
    /// <summary>
    /// Gets the not found.
    /// </summary>
    public static Error NotFound => new("User.NotFound", "The user with the specified identifier was not found.");

    /// <summary>
    /// Gets the invalid permissions.
    /// </summary>
    public static Error InvalidPermissions => new(
        "User.InvalidPermissions",
        "The current user does not have the permissions to perform that operation.");

    /// <summary>
    /// Gets the duplicate email.
    /// </summary>
    public static Error DuplicateEmail => new("User.DuplicateEmail", "The specified email is already in use.");

    /// <summary>
    /// Gets the cannot change password.
    /// </summary>
    public static Error CannotChangePassword => new(
        "User.CannotChangePassword",
        "The password cannot be changed to the specified password.");
  }

  /// <summary>
  /// Contains the attendee errors.
  /// </summary>
  public static class Attendee
  {
    /// <summary>
    /// Gets the not found.
    /// </summary>
    public static Error NotFound => new("Attendee.NotFound", "The attendee with the specified identifier was not found.");

    /// <summary>
    /// Gets the already processed.
    /// </summary>
    public static Error AlreadyProcessed => new("Attendee.AlreadyProcessed", "The attendee has already been processed.");
  }

  /// <summary>
  /// Contains the category errors.
  /// </summary>
  public static class Category
  {
    /// <summary>
    /// Gets the not found.
    /// </summary>
    public static Error NotFound => new("Category.NotFound", "The category with the specified identifier was not found.");
  }

  /// <summary>
  /// Contains the event errors.
  /// </summary>
  public static class Event
  {
    /// <summary>
    /// Gets the already cancelled.
    /// </summary>
    public static Error AlreadyCancelled => new("Event.AlreadyCancelled", "The event has already been cancelled.");

    /// <summary>
    /// Gets the event has passed.
    /// </summary>
    public static Error EventHasPassed => new(
        "Event.EventHasPassed",
        "The event has already passed and cannot be modified.");
  }

  /// <summary>
  /// Contains the group event errors.
  /// </summary>
  public static class GroupEvent
  {
    /// <summary>
    /// Gets the not found.
    /// </summary>
    public static Error NotFound => new(
        "GroupEvent.NotFound",
        "The group event with the specified identifier was not found.");

    /// <summary>
    /// Gets the user not found.
    /// </summary>
    public static Error UserNotFound => new(
        "GroupEvent.UserNotFound",
        "The user with the specified identifier was not found.");

    /// <summary>
    /// Gets the friend not found.
    /// </summary>
    public static Error FriendNotFound => new(
        "GroupEvent.FriendNotFound",
        "The friend with the specified identifier was not found.");

    /// <summary>
    /// Gets the invitation already sent.
    /// </summary>
    public static Error InvitationAlreadySent => new(
        "GroupEvent.InvitationAlreadySent",
        "The invitation for this event has already been sent to this user.");

    /// <summary>
    /// Gets the not friends.
    /// </summary>
    public static Error NotFriends => new(
        "GroupEvent.NotFriends",
        "The specified users are not friend.");

    /// <summary>
    /// Gets the date and time is in the past.
    /// </summary>
    public static Error DateAndTimeIsInThePast => new(
        "GroupEvent.InThePast",
        "The event date and time cannot be in the past.");
  }

  /// <summary>
  /// Contains the personal event errors.
  /// </summary>
  public static class PersonalEvent
  {
    /// <summary>
    /// Gets the not found.
    /// </summary>
    public static Error NotFound => new(
        "GroupEvent.NotFound",
        "The group event with the specified identifier was not found.");

    /// <summary>
    /// Gets the user not found.
    /// </summary>
    public static Error UserNotFound => new(
        "GroupEvent.UserNotFound",
        "The user with the specified identifier was not found.");

    /// <summary>
    /// Gets the date and time is in the past.
    /// </summary>
    public static Error DateAndTimeIsInThePast => new(
        "GroupEvent.InThePast",
        "The event date and time cannot be in the past.");

    /// <summary>
    /// Gets the already processed.
    /// </summary>
    public static Error AlreadyProcessed => new("PersonalEvent.AlreadyProcessed", "The event has already been processed.");
  }

  /// <summary>
  /// Contains the notification errors.
  /// </summary>
  public static class Notification
  {
    /// <summary>
    /// Gets the already sent.
    /// </summary>
    public static Error AlreadySent => new("Notification.AlreadySent", "The notification has already been sent.");
  }

  /// <summary>
  /// Contains the invitation errors.
  /// </summary>
  public static class Invitation
  {
    /// <summary>
    /// Gets the not found.
    /// </summary>
    public static Error NotFound => new(
        "Invitation.NotFound",
        "The invitation with the specified identifier was not found.");

    /// <summary>
    /// Gets the event not found.
    /// </summary>
    public static Error EventNotFound => new(
        "Invitation.EventNotFound",
        "The event with the specified identifier was not found.");

    /// <summary>
    /// Gets the user not found.
    /// </summary>
    public static Error UserNotFound => new(
        "Invitation.UserNotFound",
        "The user with the specified identifier was not found.");

    /// <summary>
    /// Gets the friend not found.
    /// </summary>
    public static Error FriendNotFound => new(
        "Invitation.FriendNotFound",
        "The friend with the specified identifier was not found.");

    /// <summary>
    /// Gets the already accepted.
    /// </summary>
    public static Error AlreadyAccepted => new("Invitation.AlreadyAccepted", "The invitation has already been accepted.");

    /// <summary>
    /// Gets the already rejected.
    /// </summary>
    public static Error AlreadyRejected => new("Invitation.AlreadyRejected", "The invitation has already been rejected.");
  }

  /// <summary>
  /// Contains the friendship errors.
  /// </summary>
  public static class Friendship
  {
    /// <summary>
    /// Gets the user not found.
    /// </summary>
    public static Error UserNotFound => new(
        "Friendship.UserNotFound",
        "The user with the specified identifier was not found.");

    /// <summary>
    /// Gets the friend not found.
    /// </summary>
    public static Error FriendNotFound => new(
        "Friendship.FriendNotFound",
        "The friend with the specified identifier was not found.");

    /// <summary>
    /// Gets the not friends.
    /// </summary>
    public static Error NotFriends => new(
        "Friendship.NotFriends",
        "The specified users are not friend.");
  }

  /// <summary>
  /// Contains the friendship request errors.
  /// </summary>
  public static class FriendshipRequest
  {
    /// <summary>
    /// Gets the not found.
    /// </summary>
    public static Error NotFound => new(
        "FriendshipRequest.NotFound",
        "The friendship request with the specified identifier was not found.");

    /// <summary>
    /// Gets the user not found.
    /// </summary>
    public static Error UserNotFound => new(
        "FriendshipRequest.UserNotFound",
        "The user with the specified identifier was not found.");

    /// <summary>
    /// Gets the friend not found.
    /// </summary>
    public static Error FriendNotFound => new(
        "FriendshipRequest.FriendNotFound",
        "The friend with the specified identifier was not found.");

    /// <summary>
    /// Gets the already accepted.
    /// </summary>
    public static Error AlreadyAccepted => new(
        "FriendshipRequest.AlreadyAccepted",
        "The friendship request has already been accepted.");

    /// <summary>
    /// Gets the already rejected.
    /// </summary>
    public static Error AlreadyRejected => new(
        "FriendshipRequest.AlreadyRejected",
        "The friendship request has already been rejected.");

    /// <summary>
    /// Gets the already friends.
    /// </summary>
    public static Error AlreadyFriends => new(
        "FriendshipRequest.AlreadyFriends",
        "The friendship request can not be sent because the users are already friends.");

    /// <summary>
    /// Gets the pending friendship request.
    /// </summary>
    public static Error PendingFriendshipRequest => new(
        "FriendshipRequest.PendingFriendshipRequest",
        "The friendship request can not be sent because there is a pending friendship request.");
  }

  /// <summary>
  /// Contains the name errors.
  /// </summary>
  public static class Name
  {
    /// <summary>
    /// Gets the null or empty.
    /// </summary>
    public static Error NullOrEmpty => new("Name.NullOrEmpty", "The name is required.");

    /// <summary>
    /// Gets the longer than allowed.
    /// </summary>
    public static Error LongerThanAllowed => new("Name.LongerThanAllowed", "The name is longer than allowed.");
  }

  /// <summary>
  /// Contains the first name errors.
  /// </summary>
  public static class FirstName
  {
    /// <summary>
    /// Gets the null or empty.
    /// </summary>
    public static Error NullOrEmpty => new("FirstName.NullOrEmpty", "The first name is required.");

    /// <summary>
    /// Gets the longer than allowed.
    /// </summary>
    public static Error LongerThanAllowed => new("FirstName.LongerThanAllowed", "The first name is longer than allowed.");
  }

  /// <summary>
  /// Contains the last name errors.
  /// </summary>
  public static class LastName
  {
    /// <summary>
    /// Gets the null or empty.
    /// </summary>
    public static Error NullOrEmpty => new("LastName.NullOrEmpty", "The last name is required.");

    /// <summary>
    /// Gets the longer than allowed.
    /// </summary>
    public static Error LongerThanAllowed => new("LastName.LongerThanAllowed", "The last name is longer than allowed.");
  }

  /// <summary>
  /// Contains the email errors.
  /// </summary>
  public static class Email
  {
    /// <summary>
    /// Gets the null or empty.
    /// </summary>
    public static Error NullOrEmpty => new("Email.NullOrEmpty", "The email is required.");

    /// <summary>
    /// Gets the longer than allowed.
    /// </summary>
    public static Error LongerThanAllowed => new("Email.LongerThanAllowed", "The email is longer than allowed.");

    /// <summary>
    /// Gets the invalid format.
    /// </summary>
    public static Error InvalidFormat => new("Email.InvalidFormat", "The email format is invalid.");
  }

  /// <summary>
  /// Contains the password errors.
  /// </summary>
  public static class Password
  {
    /// <summary>
    /// Gets the null or empty.
    /// </summary>
    public static Error NullOrEmpty => new("Password.NullOrEmpty", "The password is required.");

    /// <summary>
    /// Gets the too short.
    /// </summary>
    public static Error TooShort => new("Password.TooShort", "The password is too short.");

    /// <summary>
    /// Gets the missing uppercase letter.
    /// </summary>
    public static Error MissingUppercaseLetter => new(
        "Password.MissingUppercaseLetter",
        "The password requires at least one uppercase letter.");

    /// <summary>
    /// Gets the missing lowercase letter.
    /// </summary>
    public static Error MissingLowercaseLetter => new(
        "Password.MissingLowercaseLetter",
        "The password requires at least one lowercase letter.");

    /// <summary>
    /// Gets the missing digit.
    /// </summary>
    public static Error MissingDigit => new(
        "Password.MissingDigit",
        "The password requires at least one digit.");

    /// <summary>
    /// Gets the missing non alpha numeric.
    /// </summary>
    public static Error MissingNonAlphaNumeric => new(
        "Password.MissingNonAlphaNumeric",
        "The password requires at least one non-alphanumeric.");
  }

  /// <summary>
  /// Contains general errors.
  /// </summary>
  public static class General
  {
    /// <summary>
    /// Gets the un processable request.
    /// </summary>
    public static Error UnProcessableRequest => new(
        "General.UnProcessableRequest",
        "The server could not process the request.");

    /// <summary>
    /// Gets the server error.
    /// </summary>
    public static Error ServerError => new("General.ServerError", "The server encountered an unrecoverable error.");
  }

  /// <summary>
  /// Contains the authentication errors.
  /// </summary>
  public static class Authentication
  {
    /// <summary>
    /// Gets the invalid email or password.
    /// </summary>
    public static Error InvalidEmailOrPassword => new(
        "Authentication.InvalidEmailOrPassword",
        "The specified email or password are incorrect.");
  }
}
