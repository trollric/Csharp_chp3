using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // Will function as a contained class.
    class BenefitPackage
    {
        // Assume we have other members that represent
        // Dental/health benefits, and so on.
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }
}
