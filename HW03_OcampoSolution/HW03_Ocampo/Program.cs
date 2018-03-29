using System;

namespace HW03_Ocampo
{
	class MainClass
	{
		public static void Main(string[] args)
 		{
			int i;
			// int j;
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
			// print array before sorting 
			Console.Write("Array before sorting: ");
			for (i = 0; i <= length - 1; i++)
			{
				Console.Write(arr[i] + ", ");
			}

			int lowIndex, temp; //declare the things

			//loops for selection sort 
			for (int a = 0; a < arr.Length - 1; a++)
			{
				lowIndex = a; //set lowIndex to current index of array 

				for (int b = a + 1; b < arr.Length; b++)
				{
					if (arr[b] < arr[lowIndex])
					{
						//lowIndex will keep track of of index that min is in, this is needed because a swap happens
						lowIndex = b;

						for (i = 0; i <= length - 1; i++)
						{
							Console.Write(arr[i] + ", ");
						}
					}
				}

				//if lowIndex no longer equals i than a smaller value must have been found, so a swap must occur

				if (lowIndex != i)
				{
					temp = arr[i];
					arr[i] = arr[lowIndex];
					arr[lowIndex] = temp;

					for (i = 0; i <= length - 1; i++)
					{
						Console.Write(arr[i] + ", ");
					}
				}

				Console.Write("Array after sorting: ");
				for (i = 0; i <= length - 1; i++)
				{
					Console.Write(arr[i] + ", ");
				} 
				//Source: http://cforbeginners.com/CSharp/SelectionSort.html 		}   		// { 			// //lowIndex --> position of minimum 			//int lowIndex, temp;  			//for (int i = 0; i < arr.Length - 1; i++) 			//{ 			//	lowIndex = i; //set lowIndex to current index of array   			//	for (int j = i + 1; j < arr.Length; j++) 			//	{ 			//		if (arr[j] < arr[lowIndex]) 			//		{ 			//			//lowIndex will keep track of of index that min is in, this is needed because a swap happens 			//			lowIndex = j; 			//		} 			//	}  			//	//if lowIndex no longer equals i than a smaller value must have been found, so a swap must occur  			//	if (lowIndex != i) 			//	{ 			//		temp = arr[i]; 			//		arr[i] = arr[lowIndex]; 			//		arr[lowIndex] = temp; 			//	}
 			//	Console.Write(arr[i]);
		//	}  			//Source: http://cforbeginners.com/CSharp/SelectionSort.html 		} 
	}
}
