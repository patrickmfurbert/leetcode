public class Palindrome
{
    public bool solve(int number)
    {
        //convert number to a String
        //convert string to char array
        //need rules for even length
        //need rules for odd length

        //if element 0 is equal to negative sign, return false e
        bool isPalindrome = true;

        char[] numberArray = number.ToString().ToCharArray();

        for (int i = 0, j = numberArray.Length - 1; i <= j; i++, j--)
        {
            if (numberArray[i] != numberArray[j])
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}
