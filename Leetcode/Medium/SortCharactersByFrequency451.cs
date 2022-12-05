namespace ComputitivePrograming.Leetcode.Medium
{
    public class SortCharByFrequency
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns>sorted string by frequency</returns>
        public string Solution(string s)
        {
            var charDictionary = new Dictionary<char, int>();
            var sortedString = "";
            foreach (char currentChar in s)
            {
                if (charDictionary.ContainsKey(currentChar))
                    charDictionary[currentChar]++;
                else
                    charDictionary.Add(currentChar, 1);
            }

            foreach (var item in charDictionary.OrderByDescending(key => key.Value))
                sortedString += string.Concat(s.ToArray().Where(x => x == item.Key));

            return sortedString;
        }
    }
}
