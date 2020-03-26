namespace LowerToUpper_UpperToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] S = new string[] { "TrentReznorIsAGod" };
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] >= 'a')
                {
                    S[i] -= 'a' - 'A'; //ASCII # is 97-65
                }
                else if (S[i] <= 'a')
                {
                    S[i] += 'a' - 'A';
                }
            }
        }
    }
}
