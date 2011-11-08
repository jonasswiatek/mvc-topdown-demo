using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.TopdownDemo.IHeartQuotesData.Contract;
using DR.TopdownDemo.ServiceModel.Contract;
using DR.TopdownDemo.ServiceModel.Model;

namespace DR.TopdownDemo.IHeartQuotesService
{
    public class HeartQuotesQuoteService : IQuoteService
    {
        private readonly IQuoteRepository _quoteRepository;

        public HeartQuotesQuoteService(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;
        }

        public Quote GetRandomQuote()
        {
            var dataLayerQuote = _quoteRepository.GetRandomQuote();

            return new Quote
                       {
                           Link = dataLayerQuote.link,
                           QuoteText = dataLayerQuote.quote
                       };
        }
    }
}
