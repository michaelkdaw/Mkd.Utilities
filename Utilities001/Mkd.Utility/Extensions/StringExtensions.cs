using System;

namespace Mkd.Utility
{
	/// <summary>
	/// Provides extensions for String.
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Capitalizes the first letter of the string.
		/// </summary>
		/// <param name="str">The string to capitalize the first letter of.</param>
		/// <returns>A new string equivalent to the old one but with the first letter capitalized.</returns>
		public static string CapitalizeFirst(this string str)
		{
			if (str.Length > 0)
			{
				var first = str[0].ToString().ToUpper();
				return str.Remove(1).Insert(0, first);
			}
			return str;
		}

		/// <summary>
		/// Returns a value indicating whether a specified substring occurs within this string, in a case-insensitive manner.
		/// </summary>
		/// <param name="str">The string to search.</param>
		/// <param name="value">The string to seek.</param>
		/// <returns>true if the value parameter occurs within this string, or if value is the empty string (""); otherwise, false.</returns>
		public static bool ContainsCaseInsensitive(this string str, string value)
		{
			return str.ToLower().Contains(value.ToLower());
		}

		/// <summary>
		/// Surrounds the given string with the supplied string. Adds to beginning and end.
		/// </summary>
		/// <param name="str">The original string.</param>
		/// <param name="surroundWith">String to surround the original string with.</param>
		/// <returns>The original string surrounded by the surroundWith string.</returns>
		public static string SurroundWith(this string str, string surroundWith)
		{
			return surroundWith + str + surroundWith;
		}

		/// <summary>
		/// Tests for equivalency between two strings disregarding case.
		/// </summary>
		/// <param name="str">String to compare.</param>
		/// <param name="compareString">String to compare to.</param>
		/// <returns>True if they are the same disregarding case, false otherwise.</returns>
		public static bool EqualsNoCase(this string str, string compareString)
		{
			return str.Equals(compareString, StringComparison.InvariantCultureIgnoreCase);
		}
	}
}