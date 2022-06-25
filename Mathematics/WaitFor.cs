using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArrowUtilities.Mathematics
{
    /// <summary>
    /// <para>A static helper class for efficient generation and use of the WaitForSeconds object.</para>
    /// </summary>
    public static class WaitFor
    {
        private static Dictionary<float, WaitForSeconds> _waitForSecondsMap;

        /// <summary>
        /// <para>Accessor for a Dictionary of WaitForSeconds objects, allowing for seamless caching of WaitForSeconds without the need of declaring it in your own script.</para>
        /// </summary>
        /// <param name="seconds">Number of seconds to yield.</param>
        /// <returns>WaitForSeconds object from Dictionary</returns>
        public static WaitForSeconds Seconds(float seconds)
        {
            return _waitForSecondsMap[seconds] ?? (_waitForSecondsMap[seconds] = new WaitForSeconds(seconds));
        }
        /// <summary>
        /// <para>Accessor for a Dictionary of WaitForSeconds objects, allowing for seamless caching of WaitForSeconds without the need of declaring it in your own script.</para>
        /// </summary>
        /// <param name="minutes">Number of minutes to yield. (Multiplied by 60 for the WaitForSeconds object)</param>
        /// <returns>WaitForSeconds object from Dictionary</returns>
        public static WaitForSeconds Minutes(float minutes)
        {
            var seconds = minutes * 60;
            return _waitForSecondsMap[seconds] ?? (_waitForSecondsMap[seconds] = new WaitForSeconds(seconds));
        }

    }
}