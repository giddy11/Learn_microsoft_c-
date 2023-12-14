namespace DefiningGenerics
{
    public class Answer : ISolver
    {

        // Change these Boolean values to control whether you see 
        // the expected result and/or hints.
        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;

        // Return the largest number in the 'numbers' array.
        public static int FindLargest<T>(int[] numbers, T solver) where T : ISolver
        {
            // Your code goes here.

            return solver.Solve(numbers);
        }

        public int Solve(int[] numbers)
        {
            throw new NotImplementedException();
        }
    }

    public interface ISolver
    {
        int Solve(int[] numbers);
    }
}
