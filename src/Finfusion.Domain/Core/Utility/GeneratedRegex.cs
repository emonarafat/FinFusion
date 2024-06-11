using System.Text.RegularExpressions;

namespace Finfusion.Domain.Core.Utility;
internal static partial class GeneratedRegex
{
  private const string EmailRegexPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

  [GeneratedRegex(EmailRegexPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled, "en-US")]
  public static partial Regex EmailRegex();
}
