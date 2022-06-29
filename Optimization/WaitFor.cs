// using System.Collections.Generic;
// using UnityEngine;
//
// namespace ArrowUtilities.Optimization
// {
//     //TODO: Remove, or at least comment-out, this class. It unfortunately is just never gonna be faster than the alternatives, and is thus entirely pointless.
//     
//     
//     /// <summary>
//     /// <para>A static helper class for efficient generation and use of the WaitForSeconds object.</para>
//     /// </summary>
//     public static class WaitFor
//     {
//         private static readonly Dictionary<float, WaitForSeconds> WaitForSecondsMap = new Dictionary<float, WaitForSeconds>();
//
//         /// <summary>
//         /// <para>Accessor for a Dictionary of WaitForSeconds objects, allowing for seamless caching of WaitForSeconds without the need of declaring it in your own script.</para>
//         /// </summary>
//         /// <param name="seconds">Number of seconds to yield.</param>
//         /// <returns>WaitForSeconds object from Dictionary</returns>
//         public static WaitForSeconds Seconds(float seconds)
//         {
//             WaitForSeconds wait;
//             if (WaitForSecondsMap.TryGetValue(seconds, out wait))
//                 return wait;
//             WaitForSecondsMap.Add(seconds, new WaitForSeconds(seconds));
//             return WaitForSecondsMap[seconds];
//         }
//         /// <summary>
//         /// <para>Accessor for a Dictionary of WaitForSeconds objects, allowing for seamless caching of WaitForSeconds without the need of declaring it in your own script.</para>
//         /// </summary>
//         /// <param name="minutes">Number of minutes to yield. (Multiplied by 60 for the WaitForSeconds object)</param>
//         /// <returns>WaitForSeconds object from Dictionary</returns>
//         public static WaitForSeconds Minutes(float minutes)
//         {
//             var seconds = minutes * 60;
//             WaitForSeconds wait;
//             if (WaitForSecondsMap.TryGetValue(seconds, out wait))
//                 return wait;
//             WaitForSecondsMap.Add(seconds, new WaitForSeconds(seconds));
//             return WaitForSecondsMap[seconds];
//         }
//         
//     }
// }

