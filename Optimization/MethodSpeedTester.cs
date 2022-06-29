using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace ArrowUtilities.Optimization {
	/// <summary>
    ///     <para>
    ///         A simple testing class used to measure the speed of functions.
    ///         <br />To use it, subscribe your method(s) to a non-generic Action. The Action(s) can then be passed into
    ///         TestSingleAction, or CompareActions, for seeing which one is faster.
    ///         <br />Your results will be shown through the Debug.Log method in Unity.
    ///     </para>
    /// </summary>
    public static class MethodSpeedTester {
        /// <summary>
        ///     <para>
        ///         Simple Stopwatch-based test for execution speed of an Action over a given number of iterations.
        ///         <br />Test results will be shown via Debug.Log.
        ///     </para>
        /// </summary>
        /// <param name="action">Action you want to test.</param>
        /// <param name="iterations">How many times the Action is run during the test.</param>
        public static void TestSingleAction(Action action, int iterations) {
	        
	        #region Checks and warnings
	        if (iterations < 1) {
				Debug.LogWarning(
					"<color=red>[MethodSpeedTester.TestSingleAction]</color>: You cannot run a test with less than 1 operation!");
				return;
			}

			if (action == null) {
				Debug.LogWarning(
					"<color=red>[MethodSpeedTester.TestSingleAction]</color>: You cannot run a test with a null action!");
				return;
			}
			#endregion
			Debug.Log("<color=lime>[Arrow Utilities Method Speed Tester]</color>"); 
			Debug.Log("<color=lime>[|]</color> Starting single test...");
			var timer = Stopwatch.StartNew();
			var i = iterations;

			while (i > 0) {
				action.Invoke();
				i--;
			}

			timer.Stop();
			Debug.Log(string.Format("<color=lime>[|]</color> Test for {0} over {1} iteration(s) completed in {2}ms.",
				action.Method.Name, iterations, timer.ElapsedMilliseconds));
			Debug.Log(string.Format("<color=lime>[|]</color> Test for {0} took an average of {1}ms per operation.", action.Method.Name,
				timer.ElapsedMilliseconds / iterations));
			
			Debug.Log("<color=lime>[Test Complete]</color>");
		}

        /// <summary>
        ///     <para>
        ///         Coroutine for testing two Actions and comparing how fast they execute over a given number of iterations.
        ///         <br />Test results will be shown via Debug.Log.
        ///         <br /><b>Note: You must run this using StartCoroutine from a MonoBehaviour!</b>
        ///     </para>
        /// </summary>
        /// <param name="action1">Action that will be tested first</param>
        /// <param name="action2">Action that will be tested second</param>
        /// <param name="iterations">How many times each Action is run during the test.</param>
        /// <param name="generateLog"></param>
        /// <returns></returns>
        public static IEnumerator CompareActions(Action action1, Action action2, int iterations, bool generateLog) {
			
	        #region Checks and warnings
	        if (iterations < 1) {
				Debug.LogWarning(
					"<color=red>[MethodSpeedTester.CompareActions]</color>: You cannot run a test with less than 1 operation!");
				yield break;
			}

			if (action1 == null || action2 == null) {
				Debug.LogWarning(
					"<color=red>[MethodSpeedTester.CompareActions]</color>: You cannot run a test with a null action!");
				yield break;
			}
			#endregion
			Debug.Log("<color=lime>[Arrow Utilities Method Speed Tester]</color>");
			Debug.Log("<color=lime>[|]</color> Starting first test...");
			var timer = Stopwatch.StartNew();
			var i = iterations;
			while (i > 0) {
				action1.Invoke();
				i--;
			}

			timer.Stop();
			Debug.Log(string.Format("<color=lime>[|]</color> Test for {0} over {1} iteration(s) completed in {2}ms.",
				action1.Method.Name, iterations, timer.ElapsedMilliseconds));
			var firstTime = timer.ElapsedMilliseconds;
			yield return new WaitForSeconds(1f);
			Debug.Log("<color=lime>[|]</color> Starting second test...");
			timer = Stopwatch.StartNew();
			i = iterations;
			while (i > 0) {
				action2.Invoke();
				i--;
			}

			timer.Stop();
			Debug.Log(string.Format("<color=lime>[|]</color> Test for {0} over {1} iteration(s) completed in {2}ms.",
				action2.Method.Name, iterations, timer.ElapsedMilliseconds));
			var secondTime = timer.ElapsedMilliseconds;

			//results
			var resultString = "";
			if (firstTime < secondTime) //First Action is faster
				resultString = string.Format("<color=lime>[|]</color> RESULTS: {0} is {1}ms faster than {2} over {3} iterations",
					action1.Method.Name, secondTime - firstTime, action2.Method.Name, iterations);
			else if (secondTime < firstTime) //Second Action is faster
				resultString = string.Format("<color=lime>[|]</color> RESULTS: {0} is {1}ms faster than {2} over {3} iterations",
					action2.Method.Name, firstTime - secondTime, action1.Method.Name, iterations);
			else if (firstTime == secondTime) //Both are equal (likely only if they both are 0...)
				resultString = string.Format(
					"<color=lime>[|]</color> No difference between {0} and {1} over {2} iterations. Test inconclusive. Try increasing the iterations.",
					action1.Method.Name, action2.Method.Name, iterations);

			Debug.Log(resultString);

			if (!generateLog) {
				Debug.Log("<color=lime>[Test Complete]</color>");
				yield break;
			}

			var logFile = string.Format("ArrowUtilities CompareActions test run at {0}. " +
			                            "\nIterations: {1}." +
			                            "\nAction called {2} took {3}ms to complete." +
			                            "\nAction called {4} took {5}ms to complete." +
			                            "\nTotal difference of {6}ms.",
				DateTime.Now, iterations, action1.Method.Name,
				firstTime, action2.Method.Name, secondTime,
				Math.Abs(firstTime - secondTime));
			var dateCode = String.Format("{0:u}", DateTime.Now);
			dateCode = dateCode.Replace(":", "");
			dateCode = dateCode.Replace(" ", "");
			var fileName = string.Format("CompareActionLog {0}.txt", dateCode); 
			File.WriteAllText(Path.Combine(Application.dataPath,
				fileName), logFile);
			Debug.Log("<color=lime>[|]</color> <b>Log file " + fileName + " created</b>");
			Debug.Log("<color=lime>[Test Complete]</color>");
		}
	}
}