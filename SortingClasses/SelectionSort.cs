
namespace SortingAlgorithms
{
	public class SelectionSort
	{
		public int[] Sort(int[] arrayOfNumbers)
		{
			{	
				// j compares every single number to each number of i
				int smallestNumber;
				int tempPlacement;

				for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
				{
					smallestNumber = i;

					for (int j = i + 1; j < arrayOfNumbers.Length; j++)
					{
						if (arrayOfNumbers[j] < arrayOfNumbers[smallestNumber])
						{
							smallestNumber = j;
						}
					}

					if (smallestNumber != i)
					{
						tempPlacement = arrayOfNumbers[i];
						arrayOfNumbers[i] = arrayOfNumbers[smallestNumber];
						arrayOfNumbers[smallestNumber] = tempPlacement;
					}
				}
				return arrayOfNumbers;
				
			}
		}
	}
}