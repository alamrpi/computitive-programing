// See https://aka.ms/new-console-template for more information
using ComputitivePrograming.Leetcode.Easy;
using ComputitivePrograming.Leetcode.LinkedList;

var strHalfAlike = new ConvertBinaryNumberToInteger();

var list1 = new SingleLinkedList();
list1.AddLast(1);
list1.AddLast(0);
list1.AddLast(1);

//var list2 = new SingleLinkedList();
//list2.AddLast(1);
//list2.AddLast(3);
//list2.AddLast(4);

Console.WriteLine("Input List");
list1.Display();

var result = strHalfAlike.Solution(list1.Head());

//Console.WriteLine("Output List");
//var p = result;
//while (p != null)
//{
//    Console.Write(p.val + " --> ");
//    p = p.next;
//}
Console.WriteLine(result);