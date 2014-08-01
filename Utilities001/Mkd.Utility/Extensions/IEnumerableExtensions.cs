using System;
using System.Collections.Generic;
using System.Linq;

namespace Mkd.Utility
{
	/// <summary>
	/// Provides extension methods on EntityCollection
	/// </summary>
	public static class EnumerableExtensions
	{
		/// <summary>
		/// Performs the specified action on each element of the IEnumerable.
		/// </summary>
		/// <typeparam name="T">Generic type.</typeparam>
		/// <param name="enumerable">The IEnumerable to iterate.</param>
		/// <param name="action">The System.Action<typeparamref name="T"/> delegate to perform on each object in the IEnumerable<typeparamref name="T"/>./></param>
		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
		{
			foreach (var item in enumerable)
			{
				action(item);
			}
		}

		/// <summary>
		/// Performs the specified action on each element of the IEnumerable. Exposes the current index of the loop.
		/// </summary>
		/// <typeparam name="T">Generic type.</typeparam>
		/// <param name="enumerable">The IEnumerable to iterate.</param>
		/// <param name="action">The System.Action<typeparamref name="T"/> delegate to perform on each object in the IEnumerable<typeparamref name="T"/>./></param>
		/// <param name="index">Current index of the loop.</param>
		/// <param name="startIndex">Starting index of the loop. Default is 0.</param>
		/// <param name="doEvery">Indicates a number of items that will be skipped after the first item. Default is 1 = do every item.</param>
		/// <param name="maxIterations">The highest index to iterate to. Default is int32.MaxValue</param>
		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action, ref int index, int startIndex = 0, int doEvery = 1, int maxIterations = Int32.MaxValue)
		{
			if (doEvery < 1)
				doEvery = 1;
			var enumerable1 = enumerable as T[] ?? enumerable.ToArray();
			for (index = startIndex; index < enumerable1.Count() && index < maxIterations; index = index + doEvery)
			{
				action(enumerable1.ElementAt(index));
			}
		}
	}
}