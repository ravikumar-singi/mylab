namespace myleetcode
{

    public class BinarySearch
    {
        //ARRAY INPUT MUST BE ALREADY SORTED
        public static bool SearchInBinarySearchTree_Recursive(int[] array,
                                                              int x,
                                                              int left,
                                                              int right)
        {
            if (left > right)
                return false;

            int mid = left + ((right - left) / 2);
            if (array[mid] == x) return true;
            else if (x < array[mid])
                return SearchInBinarySearchTree_Recursive(array, x, left, mid - 1);
            else if (x > array[mid])
                return SearchInBinarySearchTree_Recursive(array, x, mid, right);
            return false;
        }

        public static bool SearchInBinarySearchTree_Iterative(int[] array, int x)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + ((right - left) / 2);
                if (array[mid] == x)
                    return true;
                else if (array[mid] < x)
                    right = mid - 1;
                else if (array[mid] > x)
                    left = mid + 1;
            }
            return false;
        }
    }
}