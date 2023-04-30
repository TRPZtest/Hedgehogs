using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hedgehogs
{
    public class HedgehogsService
    {
        public int[] GetRandomHedgehogsPopulation()
        {
            Random random = new();

            return new int[] { random.Next(1, int.MaxValue / 3), random.Next(0, int.MaxValue / 3), random.Next(0, int.MaxValue / 3) };
        }

        public int CalulateStepsToSameColor(int[] hedgehogs,int color)
        {            
            checkArguments(hedgehogs, color);

            var targetColorNumber = hedgehogs[color];

            var sourceHedgehogs = hedgehogs.Where((x, i) => i != color);

            var difference =  Math.Abs(sourceHedgehogs.First() - sourceHedgehogs.Last());

            if (difference == 0)
                return sourceHedgehogs.First();

            if (difference % 3 != 0)
                return -1;

            if (difference / 3 > targetColorNumber)
                return -1;

            return sourceHedgehogs.Max();
        }
     
        private void checkArguments(IEnumerable<int> hedgehogs, int color)
        {
            if (color < 0 || color > 2)
                throw new ArgumentException("Color can be from 0 to 2");
            if (hedgehogs.Count() > 3)
                throw new ArgumentException("There are only 3 color for hedgehogs");
            if (hedgehogs.Count() == 0 || hedgehogs.All(x => x == 0))
                throw new ArgumentException("No hedgehogs");           
        }
    }
}
