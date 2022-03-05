/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        
        ListNode resultList = new ListNode(0, null);
        this.RecursiveSum(l1, l2, resultList);
        return resultList;
        
    }
    
    public void RecursiveSum(ListNode currentl1, ListNode currentl2, ListNode currentResult) {
        if(currentl1 == null && currentl2 == null) {
            return;
        }
        var sumCurrent = currentResult.val + (currentl1?.val ?? 0) + (currentl2?.val ?? 0);
        var carry = sumCurrent/10;
        var fraction = sumCurrent%10;
            
        currentResult.val = fraction;
        if(currentl1?.next != null || currentl2?.next != null || sumCurrent/10 > 0){
            currentResult.next = new ListNode(carry, null);
        }
        this.RecursiveSum(currentl1?.next, currentl2?.next, currentResult.next);
    }
}