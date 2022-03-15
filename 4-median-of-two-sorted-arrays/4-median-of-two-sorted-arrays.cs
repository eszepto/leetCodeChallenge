public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        var sortedList = new List<int>();
        // Inserting values to a map.
        for (int i = 0; i < nums1.Length; i++) {
          sortedList.Add(nums1[i]);
        }
        for (int i = 0; i < nums2.Length; i++) {
          sortedList.Add(nums2[i]);
        }
        
        sortedList.Sort();
        if(sortedList.Count() == 1) {
            return sortedList[0];
        }
        var median = (sortedList.Count() - 1)/2.0 ;
        var floor = Convert.ToInt32(Math.Floor(median));
        var ceil = Convert.ToInt32(Math.Ceiling(median));
        return (sortedList[floor] + sortedList[ceil])/2.0;
        
        
        
        
    }
}