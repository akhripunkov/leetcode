namespace AddTwoNumbers;

 // Definition for singly-linked list.
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        bool IsOneAdded = false;
        var valSum = IsOneAdded ? l1.val + l2.val + 1 : l1.val + l2.val;
        var l3 = new ListNode(valSum%10);
        if (valSum > 9)
            IsOneAdded = true;
        else
            IsOneAdded = false;

        var savedL3 = l3; 
        
        while (l1.next != null || l2.next != null || IsOneAdded)
        {
            if (l1.next != null)
            {
                l1 = l1.next;
            }
            else
            {
                l1 = new ListNode();
            }
            
            if (l2.next != null)
            {
                l2 = l2.next;
            }
            else
            {
                l2 = new ListNode();
            }
            
            
            valSum = IsOneAdded ? l1.val + l2.val + 1 : l1.val + l2.val;
            
            l3.next = new ListNode(valSum%10);
            l3 = l3.next;
            if (valSum > 9)
                IsOneAdded = true;
            else
                IsOneAdded = false;
        }

        return l3;
    }
}