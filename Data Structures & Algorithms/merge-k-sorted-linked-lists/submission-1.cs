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
    public ListNode MergeKLists(ListNode[] lists) {

        if(lists.Length <= 0)
            return null;
        


        for(int i = 1; i < lists.Length; i++){
            lists[i] = Merge2Lists(lists[i], lists[i-1]);
        }

        return lists[lists.Length - 1];
    }

    private ListNode Merge2Lists(ListNode l1, ListNode l2){
        ListNode result = new ListNode();
        ListNode head = result;

        while(l1 != null & l2 != null){
            if(l1.val < l2.val){
                result.next = l1;
                l1 = l1.next;
            }
            else{
                result.next = l2;
                l2 = l2.next;
            }
            
            result = result.next;
        }

        if(l1 != null){
            result.next = l1;
        }
        else{
            result.next = l2;
        }

        return head.next;
    }
}
