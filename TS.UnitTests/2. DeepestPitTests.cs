using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class DeepestPitTests
{
    [TestMethod]
    public void Q2_BasicNominalTest()
    {
        var points = new[] {0, 1, 3, -2, 0, 1, -3, 2, 3};
        var result = DeepestPitAnswer.Solution(points);

        Assert.AreEqual(4, result);
    }
}
