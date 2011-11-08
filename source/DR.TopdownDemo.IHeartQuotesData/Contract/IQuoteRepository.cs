using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.TopdownDemo.IHeartQuotesData.Model;

namespace DR.TopdownDemo.IHeartQuotesData.Contract
{
    public interface IQuoteRepository
    {
        IHeartQuotesQuote GetRandomQuote();
    }
}
