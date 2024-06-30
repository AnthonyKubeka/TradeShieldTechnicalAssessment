
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        int answer = 0;
        var sentenceDelimeters = new char[]
        {
            '?',
            '.',
            '!'
        };

        var sentences = s.Split(sentenceDelimeters, StringSplitOptions.RemoveEmptyEntries);

        foreach (var sentence in sentences)
        {
            var words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (answer < words)
            {
                answer = words;
            }
        }

        return answer; 
    }
}
