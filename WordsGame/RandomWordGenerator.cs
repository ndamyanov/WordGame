using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsGame
{
   
    public static class RandomWordGenerator
    {
        private static string word;
        private static Random random;
       
        public static string NewWord()
        {
            string filePath = ConstantsParams.FilePath;
            random = new Random();
            using(var reader = new StreamReader(filePath))
            {
                int numberOfLines = File.ReadLines(filePath).Count();
                int randomNumber = random.Next(0, numberOfLines);

                word = File.ReadLines(filePath).Skip(randomNumber).Take(1).First();
            }

            string historyFile = ConstantsParams.HistoryFile;

            using (var writer = new StreamWriter(historyFile,true))
            {
                writer.WriteLine(word);
            }
                return word;
        }
    }
}
