using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoBusiness
{
    public class Misc : IMisc
    {
        public int GetOneMissingSequentialIntegerList(List<int> numbers)
        {
            var totalNumbers = numbers.Count;
            int sum = (totalNumbers + 1) * (totalNumbers + 2) / 2;

            for (int i = 0; i < totalNumbers; i++)
            {
                sum -= numbers[i];
            }

            return sum;
        }
    }
}