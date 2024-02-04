namespace AnagramCheck
{
    internal class Program
    {
        public static bool AreAnagrams(string s1, string s2)
        {
            // Uzunluk kontrolü
            if (s1.Length != s2.Length)
                return false;

            // Karakter sıklıklarını takip etmek için bir dizi oluştur
            int[] charFrequency = new int[26];

            // İlk stringin karakter sıklıklarını artır
            foreach (char c in s1)
            {
                charFrequency[c - 'a']++;
            }

            // İkinci stringin karakter sıklıklarını azalt
            foreach (char c in s2)
            {
                charFrequency[c - 'a']--;
            }

            // Eğer her iki stringin karakter sıklıkları eşitse anagramdır
            for (int i = 0; i < 26; i++)
            {
                if (charFrequency[i] != 0)
                    return false;
            }

            return true;
        }

        static void Main()
        {
            string str1 = "listen";
            string str2 = "silent";

            Console.WriteLine($"Are \"{str1}\" and \"{str2}\" anagrams? {AreAnagrams(str1, str2)}");
        }
    }
}
