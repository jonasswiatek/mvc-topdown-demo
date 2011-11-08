using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.TopdownDemo.ServiceModel.Model;

namespace DR.TopdownDemo.ServiceModel.Contract
{
    public interface IQuoteService
    {
        Quote GetRandomQuote();
    }
}
