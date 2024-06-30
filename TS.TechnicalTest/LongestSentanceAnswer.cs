
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        int answer = 0;
        var sentences = new List<string>();
        var sentenceDelimeters = new char[]
        {
            '?',
            '.',
            '!'
        };

        while (!string.IsNullOrEmpty(s))
        {
            var sentenceIndex = s.IndexOfAny(sentenceDelimeters);
            var sentence = s.Substring(0, sentenceIndex + 1).Trim();
            sentences.Add(sentence);
            s = s.Remove(0, sentenceIndex + 1);
        }

        foreach (var sentence in sentences)
        {

            var words = sentence.Split(" ").Length;
            if (answer < words)
            {
                answer = words;
            }
        }

        return answer; 
    }
}
