using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.20;
            }
            return amount * 0.15;
        }
    }
}
