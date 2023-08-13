using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithm
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode last;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;

            if(last == null)
                last = this;
        }

        public void Add(int val)
        {
            var newNode = new ListNode(val);
            last.next = newNode;
            last = newNode;
        }
    }

    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersCalculate(ListNode l1, ListNode l2)
        {
            var listNumber1 = new List<int>();
            var listNumber2 = new List<int>();

            while(l1.next != null)
            {
                listNumber1.Add(l1.val);
                l1 = l1.next;
            }
            listNumber1.Add(l1.val);

            while (l2.next != null)
            {
                listNumber2.Add(l2.val);
                l2 = l2.next;
            }
            listNumber2.Add(l2.val);

            int maxLength = listNumber1.Count > listNumber2.Count ? listNumber1.Count : listNumber2.Count;

            ListNode result = null!;
            ListNode currentNode = null!;

            bool isAddMore = false;

            int i = 0;
            int j = 0;

            while (maxLength > 0)
            {
                int num1 = 0;
                int num2 = 0;

                if (i < listNumber1.Count)
                    num1 = listNumber1[i++];
                if (j < listNumber2.Count)
                    num2 = listNumber2[j++];

                int sum = num1 + num2 + (isAddMore ? 1 : 0);

                if (sum >= 10)
                {
                    sum %= 10;
                    isAddMore = true;
                }
                else
                    isAddMore = false;

                if(result == null)
                {
                    result = new ListNode(sum);
                    currentNode = result;
                }
                else
                {
                    var newNode = new ListNode(sum);
                    currentNode!.next = newNode;
                    currentNode = newNode;
                }
                maxLength--;
            }

            if (isAddMore)
            {
                var newNode = new ListNode(1);
                currentNode!.next = newNode;
                currentNode = newNode;
            }

            return result!;

        }
    }
}
