using System;

namespace PizzaFactory.Models.Helper
{
    public class Range
    {
        public Range(int low, int high)
        {
            if (low < 0) throw new ArgumentOutOfRangeException(nameof(low));
            if (high <= 0) throw new ArgumentOutOfRangeException(nameof(high));
            if (high <= low) throw new ArgumentOutOfRangeException(nameof(high), $"{nameof(high)} must be greater than {nameof(low)}");
            Low = low;
            High = high;
        }

        public int Low { get; }
        public int High { get; }
    }
}
