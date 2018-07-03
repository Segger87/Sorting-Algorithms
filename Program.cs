using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SortingAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			Execute();
		}

		private static void Execute()
		{
			var random = RandomArray();
			Console.WriteLine("Today's Randomly selected integers are:");
			foreach (var r in random)
			{
				Console.WriteLine(r);
			}

			Seperator();

			var selectionSort = new SelectionSort().Sort(random);
			Console.WriteLine("Utilising Selection Sort:");
			foreach (var selection in selectionSort)
			{
				Console.WriteLine(selection);
			}

			Seperator();
			
			var insertionSort = new InsertionSort().Sort(random);
			Console.WriteLine("Utilising Insertion Sort:");
			foreach (var insertion in insertionSort)
			{
				Console.WriteLine(insertion);
			}

			Seperator();
			
			var mergeSort = new MergeSort().Sort(random, 0, random.Length-1);
			Console.WriteLine("Utilising Merge Sort:");
			var fullMergeWatch = Stopwatch.StartNew();
			foreach (var merge in mergeSort)
			{
				Console.WriteLine(merge);
			}
			fullMergeWatch.Stop();
			var elapsedTime = fullMergeWatch.Elapsed;

			Seperator();

			Console.WriteLine($"A Full cycle of a merge sort takes {elapsedTime} milliseconds");

			Console.WriteLine("One iteration of Selection Sort takes");
			var s = new Stopwatch();
			Console.WriteLine(s.Time(() => new SelectionSort().Sort(random), 1));

			Console.WriteLine("One iteration of Insertion Sort takes");
			var i = new Stopwatch();
			Console.WriteLine(i.Time(() => new InsertionSort().Sort(random), 1));

			Console.WriteLine("One iteration of Merge Sort takes");
			var m = new Stopwatch();
			Console.WriteLine(m.Time(() => new MergeSort().Sort(random, 0, random.Length - 1), 1));

			Seperator();
			TimeTheMethods(random);
		}

		private static void Seperator()
		{
			Console.WriteLine("=========================================================================");
		}

		private static int[] RandomArray()
		{
			// you can change the length of the array by altering the repeat value
			int Min = 0;
			int Max = 500;
			Random randNum = new Random();
			int[] nums = Enumerable
				.Repeat(0, 20)
				.Select(i => randNum.Next(Min, Max))
				.ToArray();

			return nums;
		}

		private static void TimeTheMethods(int[] random)
		{
			var thread1 = new Thread(() => new SelectionSort().Sort(random));
			var thread2 = new Thread(() => new InsertionSort().Sort(random));
			var thread3 = new Thread(() => new MergeSort().Sort(random, 0, random.Length - 1));
			
			var watchT1 = Stopwatch.StartNew();
			thread1.Start();
			watchT1.Stop();
			var elapsedMSt1 = watchT1.Elapsed;

			var watchT2 = Stopwatch.StartNew();
			thread2.Start();
			watchT2.Stop();
			var elapsedMSt2 = watchT2.Elapsed;

			var watchT3 = Stopwatch.StartNew();
			thread3.Start();
			watchT3.Stop();
			var elapsedMSt3 = watchT3.Elapsed;

			Console.WriteLine($"Thread 1 (Selection Sort) Took {elapsedMSt1} Milliseconds to execute");
			Console.WriteLine($"Thread 2 (Insertion Sort) Took {elapsedMSt2} Milliseconds to execute");
			Console.WriteLine($"Thread 3 (Merge Sort) Took {elapsedMSt3} Milliseconds to execute");
			Console.ReadLine();

		}
	}
}
