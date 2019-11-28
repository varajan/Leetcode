/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode result = null;
        
        while (true){
            if (l1 == null) {Append(l2); break;}
            if (l2 == null) {Append(l1); break;}

            Append(new ListNode( Math.Min(l1.val, l2.val) ));
            
            if (l1.val < l2.val) l1 = l1.next; else l2 = l2.next;
        }
        
        return result;
        
        void Append(ListNode node){
            if (result == null) {
                result = node;
            }else{
                ListNode current = result;
                while (current.next != null) current = current.next;
                current.next = node;
            }
        }
    }    
}
