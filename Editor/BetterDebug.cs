using System.Collections.Generic;
using UnityEngine;

namespace ArrowUtilities.Editor {
	/// <summary>
	/// <para>A class that gives the user more options for debugging their game in a nicely formatted way.</para>
	/// </summary>
	public static class BetterDebug {
		/// <summary>
		/// <para>Formatting for a block of debug messages.</para>
		/// </summary>
		public class BDBlock {
			/// <summary>
			/// <para>Color of the title, and link-icon, that display alongside block of debug messages.</para>
			/// </summary>
			public Color Color;
			/// <summary>
			/// <para>Title to appear above block of debug messages.</para>
			/// </summary>
			public string Title;
			/// <summary>
			/// <para>List of debug messages to display together.</para>
			/// </summary>
			public List<string> Messages;

			/// <summary>
			/// <para>Constructor for a block of debug messages, connected by a colored link icon.</para>
			/// </summary>
			/// <param name="color">Color for the message block to display.</param>
			/// <param name="title">Title to appear above your message block.</param>
			public BDBlock(Color color, string title) {
				Color = color;
				Title = title;
				Messages = new List<string>();
			}

			/// <summary>
			/// <para>Adds a new message to the block.</para>
			/// </summary>
			/// <param name="message">Message you'd like to add.</param>
			public void Add(string message) {
				Messages.Add(message);
			}
		}
		
		/// <summary>
		/// <para>Prints full BDBlock to the Unity console.</para>
		/// </summary>
		/// <param name="bdBlock">The Better Debug Block to print.</param>
		public static void Log(this BDBlock bdBlock) {
			var color = ColorUtility.ToHtmlStringRGB(bdBlock.Color);
			if (!ReferenceEquals(bdBlock.Title, ""))
				Debug.Log(string.Format("<color=#{0}>[{1}]</color>", color, bdBlock.Title));
			var link = string.Format("<color=#{0}>[|]</color> ", color);
			
			if (bdBlock.Messages.Count <= 0) return;
			
			foreach (var message in bdBlock.Messages) {
				Debug.Log(link + message);
			}
		}
		
		
	}
}