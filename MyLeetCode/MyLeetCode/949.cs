namespace myleetcode
{
    public class Solution949 {

     private int Max_time = -1;
    public string LargestTimeFromDigits(int[] A) {
        this.Max_time = -1;
        Permutate(A, 0);
        if (this.Max_time == -1)
            return "";
        else
            return String.Format("{0:00}:{1:00}", Max_time / 60, Max_time % 60);
    }
    
    protected void Permutate(int[] array, int start) {
        if (start == array.Length) {
            this.Build_time(array);
            return;
        }
        for (int i = start; i < array.Length; ++i) {
            this.Swap(array, i, start);
            this.Permutate(array, start + 1);
            this.Swap(array, i, start);
        }
    }

    protected void Build_time(int[] perm) {
        int hour = perm[0] * 10 + perm[1];
        int minute = perm[2] * 10 + perm[3];
        if (hour < 24 && minute < 60)
            this.Max_time = Math.Max(this.Max_time, hour * 60 + minute);
    }

    protected void Swap(int[] array, int i, int j) {
        if (i != j) {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
    
}