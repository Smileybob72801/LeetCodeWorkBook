namespace LeetCodeWorkBook
{
	internal class Program
	{
		static void Main()
		{
			int[] nums1 = [1, 2, 3, 0, 0, 0];
			int[] nums2 = [2, 5, 6];

			int m = 3;
			int n = 3;

			SortedArrayMerger merger = new();
			merger.Merge(nums1, m , nums2, n);

			Console.ReadKey();
		}
	}

	internal class SortedArrayMerger
	{
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			int pointer1 = m - 1;
			int pointer2 = n - 1;
			int targetIndex = m + n - 1;

			while(pointer1 >= 0 && pointer2 >= 0)
			{
				if (nums1[pointer1] > nums2[pointer2])
				{
					nums1[targetIndex] = nums1[pointer1];
					pointer1--;
				}
				else
				{
					nums1[targetIndex] = nums2[pointer2];
					pointer2--;
				}

				targetIndex--;
			}

			while (pointer2 >= 0)
			{
				nums1[targetIndex] = nums2[pointer2];
				pointer2--;
				targetIndex--;
			}
		}
	}
}
