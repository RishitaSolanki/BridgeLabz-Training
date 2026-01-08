public class MergeSortedArray {
   public void Merge(int[] num1, int n1, int[] num2, int n2)
{
    int i = n1 - 1;
    int j = n2 - 1;
    int k = n1 + n2 - 1;

    while (i >= 0 && j >= 0)
    {
        if (num1[i] > num2[j])
        {
            num1[k] = num1[i];
            i--;
        }
        else
        {
            num1[k] = num2[j];
            j--;
        }
        k--;
    }

    
    while (j >= 0)
    {
        num1[k] = num2[j];
        j--;
        k--;
    }
}

}