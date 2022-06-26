using System;
using System.Collections;
using System.Diagnostics;
using Debug = UnityEngine.Debug;


namespace ArrowUtilities.Optimization
{
    //TODO: Fill in summaries in this file
    //TODO: Clean up and finalize debug messages
    /// <summary>
    /// 
    /// </summary>
    public static class MethodSpeedTester
    {
        /// <summary>
        /// <para>Simple Stopwatch-based test for execution speed of an Action over a given number of iterations.</para>
        /// </summary>
        /// <param name="action">Action you want to test.</param>
        /// <param name="iterations">How many times the Action is run during the test.</param>
        public static void TestSingleAction(Action action, int iterations)
        {
            if (iterations < 1)
            {
                Debug.LogWarning("Error in MethodSpeedTester.TestSingleAction: You cannot run a test with less than 1 operation!");
                return;
            }

            if (action == null)
            {
                Debug.LogWarning("Error in MethodSpeedTester.TestSingleAction: You cannot run a test with a null action!");
                return;                
            }
            var timer = Stopwatch.StartNew();
            var i = iterations;

            while (i > 0)
            {
                action.Invoke();
                i--;
            }
            timer.Stop();
            Debug.Log(string.Format("Test for {0} over {1} iteration(s) completed in {2}ms",
                action.Method.Name, iterations, timer.ElapsedMilliseconds));
            Debug.Log(string.Format("Test for {0} took an average of {1}ms per operation", action.Method.Name, (timer.ElapsedMilliseconds / iterations)));
        }
        
        /// <summary>
        /// <para>Coroutine for testing two Actions and comparing how fast they execute over a given number of iterations.
        /// <br/><b>Note: You must run this using StartCoroutine from a MonoBehaviour!</b></para>
        /// </summary>
        /// <param name="action1">Action that will be tested first</param>
        /// <param name="action2">Action that will be tested second</param>
        /// <param name="iterations">How many times each Action is run during the test.</param>
        /// <returns></returns>
        public static IEnumerator CompareActions(Action action1, Action action2, int iterations)
        {
            if (iterations < 1)
            {
                Debug.LogWarning("Error in MethodSpeedTester.CompareActions: You cannot run a test with less than 1 operation!");
                yield break;
            }

            if (action1 == null || action2 == null)
            {
                Debug.LogWarning("Error in MethodSpeedTester.CompareActions: You cannot run a test with a null action!");
                yield break;
            }
            Debug.Log("Starting first test...");
            var timer = Stopwatch.StartNew();
            var i = iterations;
            while (i > 0)
            {
                action1.Invoke();
                i--;
            }
            timer.Stop();
            Debug.Log(string.Format("Test for {0} over {1} iteration(s) completed in {2}ms",
                action1.Method.Name, iterations, timer.ElapsedMilliseconds));
            var firstTime = timer.ElapsedMilliseconds;
            yield return WaitFor.Seconds(1f);
            Debug.Log("Starting second test...");
            timer = Stopwatch.StartNew();
            i = iterations;
            while (i > 0)
            {
                action2.Invoke();
                i--;
            }
            timer.Stop();
            Debug.Log(string.Format("Test for {0} over {1} iteration(s) completed in {2}ms",
                action2.Method.Name, iterations, timer.ElapsedMilliseconds));
            var secondTime = timer.ElapsedMilliseconds;

            if (firstTime < secondTime)
                Debug.Log(string.Format("RESULTS: {0} is {1}ms faster than {2} over {3} iterations", action1.Method.Name, secondTime - firstTime, action2.Method.Name, iterations));
            else if (secondTime < firstTime)
                Debug.Log(string.Format("RESULTS: {0} is {1}ms faster than {2} over {3} iterations", action2.Method.Name, firstTime - secondTime, action1.Method.Name, iterations));
            else if (firstTime == secondTime)
                Debug.Log(string.Format("No difference between {0} and {1} over {2} iterations / Test inconclusive.", action1.Method.Name, action2.Method.Name, iterations));
        }
    }
}