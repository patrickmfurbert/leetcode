// Solution for two sum problem on leetcode
// https://leetcode.com/problems/two-sum/description/

public class TwoSum
{
    public int[] bruteSolve(int[] numbers, int target)
    {
        //O(n^2)
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

    public int[] hashmapSolve(int[] numbers, int target)
    {
        //O(n)
        //hashmap optimization
        //I believe it something like...
        //Loop through array,
        //for each element, Check if target - elemnt is in visited
        //if not, store element in hashmap, with index as value

        int[] solution = new int[2];
        var map = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            //for the first element, it cannot be in the map
            int valueUnderTest = target - numbers[i];
            if (map.ContainsKey(valueUnderTest))
            {
                solution[0] = map[valueUnderTest];
                solution[1] = i;
                break;
            }
            else
            {
                map[numbers[i]] = i;
            }
        }

        return solution;
    }
}
