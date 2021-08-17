﻿using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Find the max
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Function that finds the max integer in a list of integers
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <returns>Integer: the max integer</returns>
        public static int Max(List<int> nums)
        {
            if(nums.Count == 0)
            {
                return 0;
            }
            
            int max = nums[0];
            foreach(var element in nums)
            {
                if (max < element)
                {
                    max = element;
                }
            }
            return max;
        }
    }
}