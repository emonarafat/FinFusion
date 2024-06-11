
using Finfusion.Domain.Core.Primitives.Maybe;

using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Finfusion.Domain.Core.Primitives;

/// <summary>
/// Represents an enumeration type.
/// </summary>
/// <typeparam name="TEnum">The type of the enumeration.</typeparam>
public abstract class Enumeration<TEnum> : IEquatable<Enumeration<TEnum>>, IComparable<Enumeration<TEnum>>
  where TEnum : Enumeration<TEnum>
{
  /// <summary>
  /// The enumerations dictionary.
  /// </summary>
  private static readonly Lazy<Dictionary<int, TEnum>> _enumerationsDictionary =
      new(() => GetAllEnumerationOptions().ToDictionary(item => item.Value));

  /// <summary>
  /// Initializes a new instance of the <see cref="Enumeration{TEnum}"/> class.
  /// </summary>
  /// <param name="value">The value.</param>
  /// <param name="name">The name.</param>
  protected Enumeration(int value, string name)
  {
    Value = value;
    Name = name;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Enumeration{TEnum}"/> class.
  /// </summary>
  /// <remarks>
  /// Required by EF Core.
  /// </remarks>
  protected Enumeration()
  {
    Value = default;
    Name = string.Empty;
  }

  /// <summary>
  /// Gets the enumeration values.
  /// </summary>
  /// <returns>The read-only collection of enumeration values.</returns>
  public static IReadOnlyCollection<TEnum> List => [.. _enumerationsDictionary.Value.Values];

  /// <summary>
  /// Gets the value.
  /// </summary>
  public int Value { get; private set; }

  /// <summary>
  /// Gets the name.
  /// </summary>
  public string Name { get; private set; }

  /// <summary>
  /// Creates an enumeration of the specified type based on the specified value.
  /// </summary>
  /// <param name="value">The enumeration value.</param>
  /// <returns>The enumeration instance that matches the specified value.</returns>
  public static Maybe<TEnum> FromValue(int value) => _enumerationsDictionary.Value
      .TryGetValue(value, out var enumeration)
    ? Maybe<TEnum>.From(enumeration)
    : Maybe<TEnum>.None;

  /// <summary>
  /// Checks if the there is an enumeration with the specified value.
  /// </summary>
  /// <param name="value">The value.</param>
  /// <returns>True if there is an enumeration with the specified value, otherwise false.</returns>
  public static bool ContainsValue(int value) => _enumerationsDictionary.Value.ContainsKey(value);

  /// <summary>
  /// Check if Enumerations are equal
  /// </summary>
  /// <param name="a"></param>
  /// <param name="b"></param>
  public static bool operator ==(Enumeration<TEnum>? a, Enumeration<TEnum>? b)
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
  public static bool operator !=(Enumeration<TEnum> a, Enumeration<TEnum> b) => !(a == b);

  /// <inheritdoc/>
  public bool Equals(Enumeration<TEnum>? other)
  {
    if (other is null)
    {
      return false;
    }

    return GetType() == other.GetType() && other.Value.Equals(Value);
  }

  /// <inheritdoc/>
  public override bool Equals(object? obj)
  {
    if (obj is null)
    {
      return false;
    }

    if (obj is not Enumeration<TEnum> otherValue)
    {
      return false;
    }

    return GetType() == obj.GetType() && otherValue.Value.Equals(Value);
  }

  /// <inheritdoc/>
  public int CompareTo(Enumeration<TEnum>? other) => other is null ? 1 : Value.CompareTo(other.Value);

  /// <inheritdoc/>
  public override int GetHashCode() => Value.GetHashCode();

  /// <summary>
  /// Gets all of the defined enumeration options.
  /// </summary>
  /// <returns>The enumerable collection of enumerations.</returns>
  private static List<TEnum> GetAllEnumerationOptions()
  {
    var enumType = typeof(TEnum);

    var enumerationTypes = Assembly
        .GetAssembly(enumType)!
        .GetTypes()
      .Where(type => enumType.IsAssignableFrom(type));

    var enumerations = new List<TEnum>();

    foreach (var enumerationType in enumerationTypes)
    {
      var enumerationTypeOptions = GetFieldsOfType<TEnum>(enumerationType);

      enumerations.AddRange(enumerationTypeOptions);
    }

    return enumerations;
  }

  /// <summary>
  /// Gets the fields of the specified type for the specified type.
  /// </summary>
  /// <typeparam name="TFieldType">The field type.</typeparam>
  /// <param name="type">The type whose fields are being retrieved.</param>
  /// <returns>The fields of the specified type for the specified type.</returns>
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
  private static List<TFieldType> GetFieldsOfType<TFieldType>([NotNull]Type type) => type.GetFields(
    BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
    .Where(fieldInfo => type.IsAssignableFrom(fieldInfo.FieldType))
    .Select(fieldInfo => (TFieldType)fieldInfo.GetValue(null))
    .ToList();
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
}
