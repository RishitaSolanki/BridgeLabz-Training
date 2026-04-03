public class RemoveDuplicatesFromSortedArray {

   public int RemoveDuplicates(int[] num)
{
    if (num.Length == 0)
        return 0;

    int l = 1; 

    for (int i = 1; i < num.Length; i++)
    {
        if (num[i] != num[l - 1])
        {
            num[l] = num[i];
            l++;
        }
    }

    return l;
}

}