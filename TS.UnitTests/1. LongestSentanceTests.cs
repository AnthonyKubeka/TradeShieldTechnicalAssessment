using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class LongestSentanceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        var input = $"We test coders. Give us a try";
        var outcome = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(4, outcome);
    }

    [TestMethod]
    public void Q1_BasicNominalTestTwo()
    {
        var input = $"Forget CVs..Save time . x x";
        var outcome = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(2, outcome);
    }
}
