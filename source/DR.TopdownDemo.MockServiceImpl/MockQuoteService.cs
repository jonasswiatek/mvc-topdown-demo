using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.TopdownDemo.ServiceModel.Contract;
using DR.TopdownDemo.ServiceModel.Model;

namespace DR.TopdownDemo.MockServiceImpl
{
    public class MockQuoteService : IQuoteService 
    {
        public Quote GetRandomQuote()
        {
            return new Quote()
                       {
                           Link = "http://iheartquotes.com/fortune/show/49981",
                           QuoteText = "I can't seem to bring myself to say, \"Well, I guess I'll be toddling along.\" It isn't that I can't toddle.  It's that I can't guess I'll toddle. -- Robert Benchley"
                       };
        }
    }
}
