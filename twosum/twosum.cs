// Solution for two sum problem on leetcode
// https://leetcode.com/problems/two-sum/description/

public class Solution
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 3 };
        int target = 6;
        Console.WriteLine(string.Join(", ", TwoSum(numbers, target)));
    }

    static int[] TwoSum(int[] numbers, int target)
    {
        //empty solution array size 2 initialized to 0
        int[] solution = new int[2];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (target - numbers[j] == numbers[i])
                {
                    solution[0] = i;
                    solution[1] = j;
                    return solution;
                }
            }
        }

        return solution;
    }
}
