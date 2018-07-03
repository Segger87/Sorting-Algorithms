using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
	public static class StopwatchExtensions
	{
		// stopwatch extension class which times one iteration of a method.
		public static TimeSpan Time(this Stopwatch sw, Action action, int iterations)
		{
			sw.Reset();
			sw.Start();
			for (int i = 0; i < iterations; i++)
			{
				action();
			}
			sw.Stop();

			return sw.Elapsed;
		}
	}
}
