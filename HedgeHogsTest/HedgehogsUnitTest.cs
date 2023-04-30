using Hedgehogs;

namespace HedgeHogsTest
{
    [TestClass]
    public class HedgehogsUnitTest
    {
        [TestMethod]
        public void OnlyOneNonTargetColor()
        {
            var hedgehogsService = new HedgehogsService();

            int[] hadheHogs = { 0, 0, 145 };

            var targetColor = 1;

            Assert.AreEqual(-1, hedgehogsService.CalulateStepsToSameColor(hadheHogs, targetColor));
        }

        [TestMethod]
        public void OnlyTargetColor()
        {
            var hedgehogsService = new HedgehogsService();

            int[] hadheHogs = { 140, 0, 0 };

            var targetColor = 0;

            Assert.AreEqual(0, hedgehogsService.CalulateStepsToSameColor(hadheHogs, targetColor));
        }

        [TestMethod]
        public void ImposibileToColorToSame()
        {
            var hedgehogsService = new HedgehogsService();

            int[] hadheHogs = { 6, 40, 300 };

            var targetColor = 2;

            Assert.AreEqual(-1, hedgehogsService.CalulateStepsToSameColor(hadheHogs, targetColor));
        }

        [TestMethod]
        public void PosibileToColorToSame()
        {
            var hedgehogsService = new HedgehogsService();

            int[] hadheHogs = { 7, 40, 300 };

            var targetColor = 2;

            Assert.AreEqual(40, hedgehogsService.CalulateStepsToSameColor(hadheHogs, targetColor));
        }
    }
}