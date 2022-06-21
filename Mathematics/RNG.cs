using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ArrowUtilities.Mathematics
{
    /// <summary>
    /// <para>Tools to assist with randomized mechanics</para>
    /// </summary>
    public static class RNG
    {
        private static System.Random rand;
        
        /// <summary>
        /// <para>A basic random boolean generator with customized win percentage</para>
        /// </summary>
        /// <param name="zeroToOne">Percent chance of success (0.35 = 35%)</param>
        /// <returns>True if the result is within the set percentage</returns>
        public static bool Chance(float zeroToOne)
        {
            return Random.value < zeroToOne;
        }
        /// <summary>
        /// <para>Boolean generator based on a random value compared against 0.5f</para>
        /// </summary>
        /// <returns>True if the value is within the 0.5f tolerance</returns>
        public static bool FiftyFifty()
        {
            return Random.value < 0.5f;
        }

        /// <summary>
        /// <para>Returns an integer between 1 and the number of sides provided. <br/><b>Note: values less than '1' will always return '-1.'</b></para>
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
        public static int DiceRoll(int sides)
        {
            if (sides >= 1) return Random.Range(0, sides) + 1;
            return -1;
        }
        

        /// <summary>
        /// <para>Generic helper function for IEnumerable that takes in an IEnumerable, and outputs a randomized version
        /// <b><br/>WARNING: This duplicates the enumerable! Avoid using in loops or performance-critical contexts.</b></para>
        /// </summary>
        /// <param name="enumerable">The IEnumerable to randomize.</param>
        /// <typeparam name="T">The type of object enumerated.</typeparam>
        /// <returns>A new IEnumerable with randomized entries.</returns>
        public static IEnumerable<T> RandomizeEnumerable<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(_ => GetReferenceToRandom().Next());
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
            return list.OrderBy(_ => GetReferenceToRandom().Next()).ToList();
        }
        
        /// <summary>
        /// <para>Generic helper function for IEnumerable that takes in a collection, and outputs a random entry.</para>
        /// </summary>
        /// <param name="enumerable">The collection to randomly draw from.</param>
        /// <typeparam name="T">The type of object listed.</typeparam>
        /// <returns>A random entry from the collection.</returns>
        public static T GetRandomEntry<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(_ => rand.Next()).First();
        }
        
        /// <summary>
        /// <para>Gets or creates a static instance of System.Random through null-coalescing assignment.</para>
        /// </summary>
        /// <returns>Static instance of System.Random()</returns>
        public static System.Random GetReferenceToRandom()
        {
            return rand ??= new System.Random();
        }
        
    }
}