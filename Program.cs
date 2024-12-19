namespace Assignment_7._2._2
{
    internal class Program
    {
        static string ReverseVowels(string s)
        {
            char[] chars = s.ToCharArray();
            string vowels = "aeiouAEIOU";
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !vowels.Contains(chars[left]))
                {
                    left++;
                }

                while (left < right && !vowels.Contains(chars[right]))
                {
                    right--;
                }

                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }

            return new string(chars);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseVowels("hello"));       
            Console.WriteLine(ReverseVowels("avacado"));    
            Console.WriteLine(ReverseVowels("intelligent")); 
        }
    }
}
