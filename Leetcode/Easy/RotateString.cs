﻿namespace ComputitivePrograming.Leetcode.Easy
{
    /// <summary>
    /// 796. Rotate String
    /// Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.
    /// A shift on s consists of moving the leftmost character of s to the rightmost position.
    /// For example, if s = "abcde", then it will be "bcdea" after one shift.
    /// </summary>
    internal class RotateString
    {
        public bool Solution(string s, string goal)
        {
            return s.Length == goal.Length && (s + s).Contains(goal);
        }
    }
}
