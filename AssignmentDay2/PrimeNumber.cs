using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    public class PrimeNumber
    {
        private async Task<bool> IsPrimeNumberAsync(int number, bool isDelay)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
                if (isDelay) await Task.Delay(5);
            }
            return true;
        }
        public async Task<List<int>> GetPrimeNumbers(int from, int to, bool isDelay)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = from; i <= to; i++)
            {
                if (await IsPrimeNumberAsync(i, isDelay)) primeNumbers.Add(i);
            }
            return primeNumbers;
        }
    }
}
