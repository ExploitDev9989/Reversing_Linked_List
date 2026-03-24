namespace Reversing_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            ListNode current = head;
            ListNode prev = null;
            ListNode temp = head;
            Console.WriteLine("Original: ");
            while (temp != null)
            {
                Console.Write(temp.val + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("\n\n");

            while (current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }
            head = prev;
            temp = head;
            Console.WriteLine("Reversed: ");
            while (temp != null)
            {
                Console.Write(temp.val+ " -> ");
                temp = temp.next;
            }
            Console.WriteLine("\n\n");

          

        }
    }
}
