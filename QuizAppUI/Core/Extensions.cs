using System;

namespace QuizAppUI.Core
{
    public static class Extensions
    {
        public static int[] GetRandomArray(int size)
        {
            int[] nums = new int[size];
            Random r = new Random();
            bool isUnique = true;
            int num;

            for (int i = 0; i < nums.Length; i++)
            {
                num = r.Next(0, size);
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] == num)
                    {
                        isUnique = false;
                        j = -1;
                        num = r.Next(0, size);
                        continue;
                    }
                    else
                    {
                        isUnique = true;
                    }
                }
                if (isUnique)
                    nums[i] = num;
            }

            return nums;
        }
    }
}
