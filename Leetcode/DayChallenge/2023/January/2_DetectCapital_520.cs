namespace ComputitivePrograming.Leetcode.DayChallenge.January
{
    internal class DetectCapital_02_520
    {
        public bool Solution(string word)
        {
            //counts lower letter and upper letter
            int capitals = 0, smalls = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'A' && word[i] <= 'Z') capitals++;
                else smalls++;
            }
            if (capitals == word.Length || smalls == word.Length) return true; //check all letter lower or upper
            else if (word[0] >= 'A' && word[0] <= 'Z' && smalls == word.Length - 1) return true; //check first letter is upper
            else return false; 
        }
    }
}
