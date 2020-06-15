using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avast.Utilities
{
    public interface IPrimeNumbers
    {
        IEnumerable<int> GetListofPrimeNumbers(int countOfPrimeNumbers);
    }
}