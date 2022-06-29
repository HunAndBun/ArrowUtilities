using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace ArrowUtilities.Mathematics {
    /// <summary>
    ///     <para>Tools to assist with randomized mechanics</para>
    /// </summary>
    // ReSharper disable once InconsistentNaming
	public static class RNG {
		private static readonly List<Color> Colors = new List<Color> {
			UnityEngine.Color.black,
			UnityEngine.Color.blue,
			UnityEngine.Color.cyan,
			UnityEngine.Color.gray,
			UnityEngine.Color.green,
			UnityEngine.Color.magenta,
			UnityEngine.Color.red,
			UnityEngine.Color.white,
			UnityEngine.Color.yellow
		};

		private static readonly char[] Letters = EnumerableHelpers.GetAlphabet();
		private static readonly char[] Digits = EnumerableHelpers.GetDigits();
		private static readonly char[] Alphanumerics = EnumerableHelpers.GetAlphanumerics();


		private static Random _rand;

        /// <summary>
        ///     <para>A basic random boolean generator with customized win percentage</para>
        /// </summary>
        /// <param name="zeroToOne">Percent chance of success (0.35 = 35%)</param>
        /// <returns>True if the result is within the set percentage</returns>
        public static bool Chance(float zeroToOne) {
			return UnityEngine.Random.value < zeroToOne;
		}

        /// <summary>
        ///     <para>Boolean generator based on a random value compared against 0.5f</para>
        /// </summary>
        /// <returns>True if the value is within the 0.5f tolerance</returns>
        public static bool FiftyFifty() {
			return UnityEngine.Random.value < 0.5f;
		}

        /// <summary>
        ///     <para>
        ///         Returns an integer between 1 and the number of sides provided. <br />
        ///         <b>Note: values less than '1' will always return '-1.'</b>
        ///     </para>
        /// </summary>
        /// <param name="sides">How many sides the die rolled has.</param>
        /// <returns></returns>
        public static int DiceRoll(int sides) {
			if (sides >= 1) return UnityEngine.Random.Range(0, sides) + 1;
			return -1;
		}

        /// <summary>
        ///     <para>Rolls a 4-sided die</para>
        /// </summary>
        /// <returns>Integer result of the roll</returns>
        public static int D4() {
			return UnityEngine.Random.Range(1, 5);
		}

        /// <summary>
        ///     <para>Rolls a 6-sided die</para>
        /// </summary>
        /// <returns>Integer result of the roll</returns>
        public static int D6() {
			return UnityEngine.Random.Range(1, 7);
		}

        /// <summary>
        ///     <para>Rolls a 10-sided die</para>
        /// </summary>
        /// <returns>Integer result of the roll</returns>
        public static int D10() {
			return UnityEngine.Random.Range(1, 11);
		}

        /// <summary>
        ///     <para>Rolls a 12-sided die</para>
        /// </summary>
        /// <returns>Integer result of the roll</returns>
        public static int D12() {
			return UnityEngine.Random.Range(1, 13);
		}

        /// <summary>
        ///     <para>Rolls a 20-sided die</para>
        /// </summary>
        /// <returns>Integer result of the roll</returns>
        public static int D20() {
			return UnityEngine.Random.Range(1, 21);
		}

        /// <summary>
        ///     <para>Gets a random color from the Unity color presets.</para>
        /// </summary>
        /// <returns>Black, Blue, Cyan, Gray, Green, Magenta, Red, White, or Yellow</returns>
        public static Color UnityColor() {
			return Colors.GetRandomEntry();
		}

        /// <summary>
        ///     <para>
        ///         Gets a random color using randomized R, G, and B values.
        ///         <br /><b>Note: Use RNG.UnityColor to get only the preset color options.</b>
        ///     </para>
        /// </summary>
        /// <returns>Randomized color. <br />(Alpha is always set to 1.)</returns>
        public static Color Color() {
			return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1);
		}

        /// <summary>
        ///     <para>Randomly retrieves a letter from A to Z.</para>
        /// </summary>
        /// <returns>Any letter from A to Z.</returns>
        public static char Letter() {
			return Letters[UnityEngine.Random.Range(0, 26)];
		}

        /// <summary>
        ///     <para>Randomly retrieves a digit from 0 to 9.</para>
        /// </summary>
        /// <returns>Any digit from 0 to 9 as a Char.</returns>
        public static char Digit() {
			return Digits[UnityEngine.Random.Range(0, 10)];
		}

        /// <summary>
        ///     Randomly retrieves a letter or digit from A to Z or 0 to 9 respectively.
        /// </summary>
        /// <returns>Any alphanumeric from A to Z or 0 to 9.</returns>
        public static char Alphanumeric() {
			return Alphanumerics[UnityEngine.Random.Range(0, 36)];
		}

        /// <summary>
        ///     <para>Gets or creates a static instance of System.Random through null-coalescing assignment.</para>
        /// </summary>
        /// <returns>Static instance of System.Random()</returns>
        public static Random GetReferenceToRandom() {
			return _rand ?? (_rand = new Random());
		}
	}
}