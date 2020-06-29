using Spike.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spike.Domain
{
    public interface ICurrencyLookup
    {
        CurrencyDetails FindCurrency(string currencyCode);
    }
    public class CurrencyDetails : ValueObject<CurrencyDetails>
    {
        public string CurrencyCode { get; set; }
        public bool InUse { get; set; }
        public int DecimalPlaces { get; set; }
        public static CurrencyDetails None = new CurrencyDetails
        {
            InUse = false
        };
    }

}
