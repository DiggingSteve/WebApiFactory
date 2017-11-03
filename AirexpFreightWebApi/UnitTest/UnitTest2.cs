using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace UnitTest
{
    public class Solution
    {

        public bool JudgeCircle()
        {
            string moves = "LL";
            if (moves.Length % 2 == 1) return false;
            int u = 0, d = 0, l = 0, r = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'U':
                        u++;
                        break;
                    case 'L':
                        l++;
                        break;
                    case 'R':
                        r++;
                        break;
                    case 'D':
                        d++;
                        break;
                }
            }


            return (r == l) && (u == d);
        }


    }



    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution1
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return Construct(nums, 0, nums.Length);
        }

        public TreeNode Construct(int[] nums, int leftIndex, int rightIndex)
        {
            int maxI = GetMaxIndex(nums, leftIndex, rightIndex);
            TreeNode root = new TreeNode(nums[maxI]);
            root.left = Construct(nums, leftIndex, maxI);
            root.right = Construct(nums, maxI + 1, rightIndex);
            return root;
        }

        public int GetMaxIndex(int[] nums, int leftIndex, int rightIndex)
        {
            int maxIndex = leftIndex;
            for (int i = leftIndex; i < rightIndex; i++)
            {
                if (nums[maxIndex] < nums[rightIndex])
                    maxIndex = rightIndex;
            }
            return maxIndex;
        }
    }

    public class Solution2
    {
        public int ArrayPairSum(int[] nums)
        {
            nums = new int[] { 1, 4, 3, 5 };
            int[] exist = new int[20001];
            for (int i = 0; i < nums.Length; i++)
            {
                exist[nums[i] + 10000]++;
            }
            int sum = 0;
            bool odd = true;
            for (int i = 0; i < exist.Length; i++)
            {
                while (exist[i] > 0)
                {
                    if (odd)
                    {
                        sum += i - 10000;
                    }
                    odd = !odd;
                    exist[i]--;
                }
            }
            return sum;

        }
    }

    public class Solution4
    {
        public bool IsPerfectSquare(int x)
        {
            x = 100;
            long r = x;
            while (r * r > x)
                r = (r + x / r) / 2;
            return r * r == x;
        }
    }

   
      

}
