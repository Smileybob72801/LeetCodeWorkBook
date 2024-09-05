namespace LeetCodeWorkBook
{
	internal class Program
	{
		static void Main()
		{
			int[] nums1 = [1, 2, 3, 0, 0, 0];
			int[] nums2 = [2, 5, 6];

			int m = nums1.Length;
			int n = nums2.Length;

			SortedArrayMerger merger = new();
			merger.Merge(nums1, m , nums2, n);
		}
	}

	internal class SortedArrayMerger
	{
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			int pointer1 = 0;
			if (m > 0)
			{
				pointer1 = nums1[0];
			}

			int pointer2 = 0;
			if (n > 0)
			{
				pointer2 = nums2[0];
			}

			int pointer2Index = 0;
			int pointer1Index = 0;

			int[] result = new int[m + n];

			for (int i = 0; i < nums1.Length - 1; i++)
			{
				if (pointer1 <= pointer2 && pointer1Index < m)
				{
					result[i] = pointer1;
					pointer1Index++;
					pointer1 = nums1[pointer1Index];
				}
				else if (pointer2Index < n)
				{
					result[i] = pointer2;
					pointer2Index++;
					pointer2 = nums2[pointer2Index];
				}
			}

			nums1 = result;
		}
	}
}
