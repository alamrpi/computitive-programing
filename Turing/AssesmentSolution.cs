

namespace ComputitivePrograming.Turing
{
    public class AssesmentSolution
    {
        public void Solution()
        {
            string morsecode = "....";
            IList<string> output = new List<string>();
            for (int i = 0; i < morsecode.Length - 1; i++)
            {
                output.Add(morsecode.Replace("..", "--"));
            }


            Console.WriteLine("");  //Will print a
        }
    }
}
