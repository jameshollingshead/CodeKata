using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterruptedBubbleSort
{
    public class BubbleSort
    {
        static void Main(string[] args)
        {
        }

        public int[] PerformNBubbleSorts(int[] inputNumbers, int numberOfPasses)
        {
            int[] result = inputNumbers;
            int tmp;

            for (int i = 0; i < numberOfPasses; i++)
            {
                for(int j = 0; j<result.Length; j++)
                {
                    if((j+1 < result.Length) && (result[j] > result[j+1]))
                    {
                        tmp = result[j + 1];
                        result[j + 1] = result[j];
                        result[j] = tmp;
                    }
                }
            }

                return result;
        }
    }
}
