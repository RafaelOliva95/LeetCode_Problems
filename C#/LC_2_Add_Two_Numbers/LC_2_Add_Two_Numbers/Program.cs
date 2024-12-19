public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
    
    public static void Main(string[] args)
    {
        ListNode l1 = CreateList(9);
        ListNode l2 = CreateList(999999991);
        ListNode result = AddTwoNumbers(l1, l2);
        while (result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode index1 = l1;
        ListNode index2 = l2;
        long multiplier = 1;
        long num1 = 0;
        long num2 = 0;
        while (index1 != null)
        {
            num1 += index1.val * multiplier;
            index1 = index1.next;
            multiplier *= 10;
        }
        multiplier = 1;
        while (index2 != null)
        {
            num2 += index2.val * multiplier;
            index2 = index2.next;
            multiplier *= 10;
        }
        long sum = num1 + num2;
        return CreateList(sum);
    }
    public static ListNode CreateList(long number)
    {
        int temp = (int)(number % 10);
        ListNode result = new ListNode(temp);
        ListNode others = result;
        number /= 10;
        while (number != 0)
        {
            temp = (int)(number % 10);
            others.next = new ListNode(temp);
            others = others.next;
            number /= 10;
        }
        return result;
    
    }
}