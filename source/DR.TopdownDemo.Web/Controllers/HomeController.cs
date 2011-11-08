using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DR.TopdownDemo.ServiceModel.Contract;
using DR.TopdownDemo.Web.Models;

namespace DR.TopdownDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuoteService _quoteService;

        public HomeController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public ActionResult Index()
        {
            var randomQuote = _quoteService.GetRandomQuote();
            var quoteDvo = new QuoteDvo
                               {
                                   Link = randomQuote.Link,
                                   QuoteText = randomQuote.QuoteText
                               };
            return View(quoteDvo);
        }
    }
}
