namespace Task68
{
    public class Program
    {
        static bool Isinterleave(string s1, string s2, string s3)
        {
            if(s1.Length+s2.Length!=s3.Length)
                return false;
            int i = 0;
            int j = 0;
            for (int k = 0; k < s3.Length; k++)
            {
                if (i < s1.Length && s3[k] == s1[i])
                {
                    i++;
                }
                else if (j < s2.Length && s3[k] == s2[j])
                {
                    j++;
                }
                else 
                {
                    return false;
                }

                
            }
            return true;

        }
        static void Main(string[] args)
        {
            string s1 = "AAB";
            string s2 = "AAC";
            string s3 = "AAAABC";
            bool result=Isinterleave(s1, s2, s3);
            Console.WriteLine(result);
        }
    }
}
