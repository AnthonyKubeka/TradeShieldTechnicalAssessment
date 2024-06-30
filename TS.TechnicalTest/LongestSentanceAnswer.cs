﻿
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

        for (int i = 0; i < 100; i++)
        {
            var sentenceIndex = s.IndexOfAny(sentenceDelimeters);
            var sentence = s.Substring(0, sentenceIndex + 1);
            sentences.Add(sentence);
            s = s.Remove(0, sentenceIndex + 1);
        }

        return answer; 
    }
}
