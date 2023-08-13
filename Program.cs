using Leetcode.Algorithm;

var listNode1 = new ListNode(2);
listNode1.Add(4);
listNode1.Add(9);

var listNode2 = new ListNode(5);
listNode2.Add(6);
listNode2.Add(4);
listNode2.Add(9);

var addTwoNumber = new AddTwoNumbers();

var result = addTwoNumber.AddTwoNumbersCalculate(listNode1, listNode2); 
