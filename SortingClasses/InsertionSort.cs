
namespace SortingAlgorithms
{
	class InsertionSort
	{
		public int[] Sort(int[] arrayOfNumbers)
		{
			{
				int tempPlacement;
				int j;

				for (int i = 1; i < arrayOfNumbers.Length; i++)

				{
					tempPlacement = arrayOfNumbers[i];
					j = i - 1;

					while (j >= 0 && arrayOfNumbers[j] > tempPlacement)
					{
						arrayOfNumbers[j + 1] = arrayOfNumbers[j];
						j--;
					}

					arrayOfNumbers[j + 1] = tempPlacement;
				}

				return arrayOfNumbers;
			}
		}
	}
}

