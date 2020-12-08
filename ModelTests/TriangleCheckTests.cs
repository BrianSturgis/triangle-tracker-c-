using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleCheckTests
  {
    [TestMethod]
    public void TriangleCalc_OneSideGreaterThanOthersCombined_NotATriangle()
    {
      Assert.AreEqual("Not a triangle", TriangleCheck.TriangleCalc(8,2,2));
    } 
    [TestMethod]
    public void TriangleCalc_AllSidesEqual_IsEquilateral()
    {
      Assert.AreEqual("Equilateral", TriangleCheck.TriangleCalc(2,2,2));
    } 
    [TestMethod]
    public void TriangleCalc_OneSideGreater_Isoceles()
    {
      Assert.AreEqual("Isoceles", TriangleCheck.TriangleCalc(1,2,2));
    }
    [TestMethod]
    public void TriangleCalc_NoSidesEqual_IsScalene()
    {
      Assert.AreEqual("Scalene", TriangleCheck.TriangleCalc(2, 3, 4));
    } 
  }
}