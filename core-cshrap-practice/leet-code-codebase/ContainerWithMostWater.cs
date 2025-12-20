 using System;
 public class ContainerWithMostWater {
    public int MaxArea(int[] arr) {
	
 //Leetcode Question Container With Most Water   
        int max =0;
        int start =0;
        int end = arr.Length-1;
		
        while (start<endd){
            int height = Math.Min(arr[st],arr[ed]);
			
            int width = end - start;
			
			//As container is rectangle shape so..
			//we use area of rectangle=height*width
			
            int area = height*width;
			
            max = Math.Max(max,area);
			
            if(arr[start]<arr[end]){
             start++;
            }
			else {
                end--;
            }

        }
       
      return max;
        
    }
}