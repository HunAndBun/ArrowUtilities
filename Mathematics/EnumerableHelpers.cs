using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ArrowUtilities.Mathematics {
	//---------------------------------------------------------------DONE FOR NOW---------------------------------------------------


    /// <summary>
    ///     <para>Static class containing extension methods for implementors of the generic IEnumerable such as List or Array.</para>
    /// </summary>
    public static class EnumerableHelpers {

	    #region Basic Character Arrays
	    /// <summary>
        ///     <para>Shortcut for adding all 26 letters of the alphabet to an array. (Utilized in RNG.Letter)</para>
        /// </summary>
        /// <returns>Char[] with all 26 letters of the alphabet.</returns>
        public static char[] GetAlphabet() {
			return "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
		}

        /// <summary>
        ///     <para>Shortcut for adding all 10 digits to an array. (Utilized in RNG.Digit)</para>
        /// </summary>
        /// <returns>Char[] with all 10 numeric digits.</returns>
        public static char[] GetDigits() {
			return "0123456789".ToCharArray();
		}

        /// <summary>
        ///     <para>Shortcut for adding all 36 alphanumeric characters to an array.</para>
        /// </summary>
        /// <returns>Char[] with all 36 alphanumeric characters.</returns>
        public static char[] GetAlphanumerics() {
			return "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
		}
        
		#endregion
		
		
        /// <summary>
        ///     <para>Generic function for initializing an array with the contents filled with a single value.</para>
        /// </summary>
        /// <param name="length">Number of entries on resulting array.</param>
        /// <param name="fill">Object or value to fill every entry with.</param>
        /// <typeparam name="T">Type of value or reference being stored.</typeparam>
        /// <returns>Array with the same entry at every index.</returns>
        public static T[] GetPreFilledArray<T>(int length, T fill) { //NOTE: Array.Fill is not compatible with .NET Framework 4.7.1, so this method is the only option.
			var array = new T[length];
			for (var i = 0; i < length; i++) array[i] = fill;
			return array;
		} 
        
		//Randomizers

        /// <summary>
        ///     <para>
        ///         Generic helper function for implementors of generic IEnumerable that takes in an IEnumerable, and outputs a
        ///         randomized version
        ///         <b><br />WARNING: This duplicates the enumerable! Avoid using in loops or performance-critical contexts.</b>
        ///     </para>
        /// </summary>
        /// <param name="enumerable">The IEnumerable to randomize.</param>
        /// <typeparam name="T">The type of object enumerated.</typeparam>
        /// <returns>A new IEnumerable with randomized entries.</returns>
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> enumerable) {
			return enumerable.OrderBy(_ => RNG.GetReferenceToRandom().Next());
		}


        /// <summary>
        ///     <para>Generic helper function for IEnumerable that takes in a collection, and outputs a random entry.</para>
        /// </summary>
        /// <param name="enumerable">The collection to randomly draw from.</param>
        /// <typeparam name="T">The type of object listed.</typeparam>
        /// <returns>A random entry from the collection.</returns>
        public static T GetRandomEntry<T>(this IEnumerable<T> enumerable) {
			var enumerable1 = enumerable.ToList();
			return enumerable1[Random.Range(0, enumerable1.Count)];
		}
	}
}