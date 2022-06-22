using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ArrowUtilities.Mathematics
{
    public static class EnumerableHelpers
    {

        /// <summary>
        /// <para>Generic function for initializing an array with the contents filled with a single value.</para>
        /// </summary>
        /// <param name="length">Number of entries on resulting array.</param>
        /// <param name="fill">Object or value to fill every entry with.</param>
        /// <typeparam name="T">Type of value or reference being stored.</typeparam>
        /// <returns>Array with the same entry at every index.</returns>
        public static T[] GetPreFilledArray<T>(int length, T fill)
        {
            var array = new T[length];
            for (var i = 0; i < length; i++)
            {
                array[i] = fill;
            }

            return array;
        }


        //Randomizers
        
        /// <summary>
        /// <para>Generic helper function for IEnumerable that takes in an IEnumerable, and outputs a randomized version
        /// <b><br/>WARNING: This duplicates the enumerable! Avoid using in loops or performance-critical contexts.</b></para>
        /// </summary>
        /// <param name="enumerable">The IEnumerable to randomize.</param>
        /// <typeparam name="T">The type of object enumerated.</typeparam>
        /// <returns>A new IEnumerable with randomized entries.</returns>
        public static IEnumerable<T> RandomizeEnumerable<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(_ => RNG.GetReferenceToRandom().Next());
        }
        /// <summary>
        /// <para>Generic helper function for List that takes in a List, and outputs a randomized version
        /// <b><br/>WARNING: This duplicates the List! Avoid using in loops or performance-critical contexts.</b></para>
        /// </summary>
        /// <param name="list">The List to randomize.</param>
        /// <typeparam name="T">The type of object listed.</typeparam>
        /// <returns>A new List with randomized entries.</returns>
        public static List<T> RandomizeList<T>(this List<T> list)
        {
            return list.OrderBy(_ => RNG.GetReferenceToRandom().Next()).ToList();
        }
        
        /// <summary>
        /// <para>Generic helper function for IEnumerable that takes in a collection, and outputs a random entry.</para>
        /// </summary>
        /// <param name="enumerable">The collection to randomly draw from.</param>
        /// <typeparam name="T">The type of object listed.</typeparam>
        /// <returns>A random entry from the collection.</returns>
        public static T GetRandomEntry<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(_ => RNG.GetReferenceToRandom().Next()).First();
        }

    }
}