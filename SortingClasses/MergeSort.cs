using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
	public class MergeSort
	{
		public int[] Sort(int[] arrayOfNumbers, int left, int right)
		{
			if (left < right)
			{
				int middle = (left + right) / 2;

				Sort(arrayOfNumbers, left, middle);
				Sort(arrayOfNumbers, middle + 1, right);

				//Merge
				int[] leftArray = new int[middle - left + 1];
				int[] rightArray = new int[right - middle];

				Array.Copy(arrayOfNumbers, left, leftArray, 0, middle - left + 1);
				Array.Copy(arrayOfNumbers, middle + 1, rightArray, 0, right - middle);

				int i = 0;
				int j = 0;
				for (int k = left; k < right + 1; k++)
				{
					if (i == leftArray.Length)
					{
						arrayOfNumbers[k] = rightArray[j];
						j++;
					}
					else if (j == rightArray.Length)
					{
						arrayOfNumbers[k] = leftArray[i];
						i++;
					}
					else if (leftArray[i] <= rightArray[j])
					{
						arrayOfNumbers[k] = leftArray[i];
						i++;
					}
					else
					{
						arrayOfNumbers[k] = rightArray[j];
						j++;
					}
				}
			}
			
			return arrayOfNumbers;

		}
	}
}
