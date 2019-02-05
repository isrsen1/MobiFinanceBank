using MobiFinanceBank.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using MobiFinanceBank.Services.Interfaces;

namespace MobiFinanceBank.Services
{
    /// <summary>
    /// Exchange service
    /// </summary>
    /// <seealso cref="IExchangeService"/>
    public class ExchangeService: IExchangeService
    {
        /// <summary>
        /// Gets or sets the base api uri 
        /// </summary>
        /// <value>
        /// Base api uri
        /// </value>
        public string BaseUri { get; set; } = "http://api.hnb.hr/tecajn/v1";

        /// <summary>
        /// Get currency exchange rates
        /// </summary>
        /// <param name="currencies">List of filtered currencies</param>
        /// <param name="fromDate">From date filter</param>
        /// <param name="toDate">To date filter</param>
        /// <returns>
        /// JSON result
        /// </returns>
        public string GetCurrencyExchangeRates(IEnumerable<Currency> currencies, DateTime? fromDate, DateTime? toDate)
        {
            string parameters = "?";

            //if((fromDate != null && fromDate > DateTime.Now) || (fromDate != null && toDate != null))
            //    throw new ArgumentException("Datum 'od' veći od datuma 'do'");

            // If currency list contains data, add to uri
            if (currencies != null && currencies.Any())
            {
                foreach (var currency in currencies)
                {
                    parameters += $"valuta={currency}&";
                }
            }
            
            // Add date from to uri
            if (fromDate != null)
                parameters += $"datum-od={String.Format("{0:yyyy-MM-dd}", fromDate)}&";

            // Add date to to uri
            if(toDate != null)
                parameters += $"datum-do={String.Format("{0:yyyy-MM-dd}", toDate)}&";

            // using http client for hnb api
            using (HttpClient client = new HttpClient())
            {
                // Setting base address and sending get request
                client.BaseAddress = new Uri(this.BaseUri);
                var response = client.GetAsync(parameters).Result;

                var result = response.Content.ReadAsStringAsync().Result;

                // if response status ok, return response
                if (response.IsSuccessStatusCode)
                    return result;

                throw new HttpRequestException($"Could not retrieve currency exchange rates, status code {response.StatusCode}");
            }
        }
    }
}
