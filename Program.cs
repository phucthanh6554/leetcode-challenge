using System.Reflection.PortableExecutable;
using Leetcode.Algorithm;

var service = new PalindromeLinkedListProblem();

var list = new ListNode(1, new ListNode(2, new ListNode(2 ,new ListNode(1))));

var result = service.IsPalindrome(list);

Console.WriteLine();