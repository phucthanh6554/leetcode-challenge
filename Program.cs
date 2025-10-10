
using System.Text.RegularExpressions;
using Leetcode.Algorithm;

var node = new ListNode(-10, new ListNode(-3, new ListNode(0, new ListNode(5, new ListNode(9)))));

var service = new TakingMaximumEnergyProblem();

var energy = new int[] { 5, -10, 4, 3, 5, -9, 9, -7 };

var result = service.MaximumEnergy(energy, 2);


Console.WriteLine();