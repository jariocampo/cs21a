using System;

namespace MidtermProjectDraft
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Define Variables
			//int p;
			//int n;
			//int i;

			//Array creation, input values

			Console.WriteLine("Please input how many values are to be sorted");
			int length = int.Parse(Console.ReadLine());

			//how many values will be selection sorted???? 
			int[] arr = new int[length]; // int is an array with the length *length*


			//input values for sorting
			Console.WriteLine("Please input values to be sorted");
			for (int c = 0; c < length; c++)
			{
				arr[c] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("1 BubblySort");
			Console.WriteLine("2 Binsertion Sort");
			Console.WriteLine("3 Selection Sort");
			Console.WriteLine("Please type the number of the sort you wish to implement");
			int sortChoice = int.Parse(Console.ReadLine());

			if (sortChoice = 1) //BubblySort
			///Algorithm BubblySort
			////Input: an integer array A of size n
			////Output: the same integer array in increasing order

			////for p ← 1 to n / 2 do
			////	for i ← p - 1 to(n - 1) - p do
			////		if A[i] > A[i + 1]
			////			Swap(A[i], A[i + 1])
			////for i ← n - p - 1 downto p do
			////	if A[i] < A[i - 1]
			////		Swap(A[i], A[i - 1])
			{
				for (int p = 1; p = arr.Length / 2; p++)
				{
					for (int i = p - 1; i <= arr.Length - 1; i++)
					{
						if (arr[i] > arr[i + 1])
						{
							//Swap(A[i], A[i + 1])
							// Swap(arr[i], arr[i - 1]); ????
							int temp = arr[i];
							arr[i] = arr[i + 1];
							arr[i + 1] = temp;
						}
					}

					for (int i = arr.Length - p - 1; i >= p; i--)
					{
						if (arr[i] < arr[i - 1])
						{
							int temp = arr[i];
							arr[i] = arr[i - 1];
							arr[i - 1] = arr[i];
						}
					}
				}
			}

					              else if (sortChoice = 2) // Binsertion Sort
					              ////Algorithm BinsertionSort
			////Input: an integer array A of size n
			////Output: the same integer array in increasing order
			////for i ← 1 to n - 1 do
			////	ins ← A[i]
			////	p ← BinarySearch(A, i - 1, ins)
			////for j ← i - 1 downto p do
			////	A[j + 1] ← A[j]
			////A[p] ← ins
					{
				string output = "";
				for (int i = 1; i <= arr.Length - 1; i++)
				{
					int ins = arr[i];
					int p = BinarySearch(arr, i - 1, ins)
						for (int j = i - 1; j >= p; j--)
				{
					arr[j + 1] = arr[j];
							}
				arr[p] = ins;
				output += "\n";
				for (int l = 0; l <= arr.Length - 1; l++)
				{
					output += arr[l] + " ";
							}
					}
			return output;

								     else if(sortChoice = 3) // Selection Sort
							{
				public void selectSort(int[] arr)
		{
			//pos_min is short for position of min
			int pos_min, temp;

			for (int i = 0; i < arr.Length - 1; i++)
			{
				pos_min = i;//set pos_min to the current index of array

				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j] < arr[pos_min])
					{
						//pos_min will keep track of the index that min is in, this is needed when a swap happens
						pos_min = j;
					}
				}

				//if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
				if (pos_min != i)
				{
					temp = arr[i];
					arr[i] = arr[pos_min];
					arr[pos_min] = temp;
				}
			}
		}
		}

