using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using DR.TopdownDemo.IHeartQuotesData.Contract;
using DR.TopdownDemo.IHeartQuotesData.Model;

namespace DR.TopdownDemo.IHeartQuotesData
{
    public class HeartQuotesQuoteRepository : IQuoteRepository
    {
        private readonly JavaScriptSerializer _javaScriptSerializer = new JavaScriptSerializer();
        private const string RandomQuoteUrl = "http://www.iheartquotes.com/api/v1/random?format=json";

        public IHeartQuotesQuote GetRandomQuote()
        {
            var webClient = new WebClient();
            var jsonData = webClient.DownloadString(RandomQuoteUrl);
            var result = _javaScriptSerializer.Deserialize<IHeartQuotesQuote>(jsonData);

            return result;
        }
    }
}
