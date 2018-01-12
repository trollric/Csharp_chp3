using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string name, int age, int empID, float currPay, string ssn, int saleNum) :base(name, age, empID, currPay, ssn, saleNum )   
        {

        }
    }
}
