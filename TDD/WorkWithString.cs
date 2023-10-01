using System;

namespace TDD
{
    public class WorkWithString
    {
        public WorkWithString()
        {

        }

        public int Finding_am(string line)
        {
            int count = 0;
            int index = 0;

            while ((index = line.IndexOf("ам", index, StringComparison.InvariantCultureIgnoreCase)) != -1)
            {
                count++;
                index += 2;
            }

            return count;
        }

        public char Ninth_char(string line)
        {
            if (line.Length < 8)
            {
                throw new NotImplementedException();
            }
            return line[8];
        }

        public int Numb_of_char(string line)
        {
            int len = line.Length;
            return len;

        }

        public int Numb_of_words(string line)
        {
            int count = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }

        public string Shortest_word(string line)
        {
            string[] words = line.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                throw new ArgumentException("Строка не содержит слов.");
            }

            string shortestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }

            return shortestWord;
        }
    }
}