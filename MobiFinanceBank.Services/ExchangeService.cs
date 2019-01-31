using MobiFinanceBank.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobiFinanceBank.Services
{
    /// <summary>
    /// Exchange service
    /// </summary>
    public class ExchangeService
    {
        public string BaseUri { get; set; } = "http://api.hnb.hr/tecajn/v1";
        public HttpResponseMessage CurrentAllCurrencyExchangeRate(IEnumerable<Currency> currencies, DateTime? fromDate, DateTime? toDate)
        {
            string parameters = "?";

            if (currencies != null && currencies.Any())
            {
                foreach (var currency in currencies)
                {
                    parameters += $"valuta={currency}&";
                }
            }
            
            if (fromDate != null)
                parameters += $"datum-od={String.Format("{0:yyyy-MM-dd}", fromDate)}&";

            if(toDate != null)
                parameters += $"datum-do={String.Format("{0:yyyy-MM-dd}", toDate)}&";

            // using http client for hnb api
            using (HttpClient client = new HttpClient())
            {
                // Setting base address and sending get request
                client.BaseAddress = new Uri(this.BaseUri);
                var response = client.GetAsync(parameters).Result;

                //string result = response.Content.ReadAsStringAsync().Result;

                // if response status ok, return response
                if (response.IsSuccessStatusCode)
                    return response;

                // return bad request
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
