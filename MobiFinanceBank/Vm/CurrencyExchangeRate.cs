using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Enums;
using Newtonsoft.Json;

namespace MobiFinanceBank.Vm
{
    /// <summary>
    /// Currency exchange rate class
    /// </summary>
    public class CurrencyExchangeRate
    {
        /// <summary>
        /// Exchange rate list
        /// </summary>
        /// <value>
        /// Exchange rate list
        /// </value>
        [JsonProperty("Broj tečajnice")]
        public string ExchangeRateList { get; set; }

        /// <summary>
        /// Application date 
        /// </summary>
        /// <value>
        /// Application date
        /// </value>
        [JsonProperty("Datum primjene")]
        public string ApplicationDate { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>
        /// Country
        /// </value>
        [JsonProperty("Država")]
        public string Country { get; set; }

        /// <summary>
        /// Currency code
        /// </summary>
        /// <value>
        /// Currency code
        /// </value>
        [JsonProperty("Šifra valute")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>
        /// Currency name
        /// </value>
        [JsonProperty("Valuta")]
        public string Currency { get; set; }

        /// <summary>
        /// Currency unit
        /// </summary>
        /// <value>
        /// Unit
        /// </value>
        [JsonProperty("Jedinica")]
        public int Unit { get; set; }

        /// <summary>
        /// Buying currency rate value
        /// </summary>
        /// <value>
        /// Buying currency rate value
        /// </value>
        [JsonProperty("Kupovni za devize")]
        public string Buying { get; set; }
        
        /// <summary>
        /// Middle currency rate value
        /// </summary>
        /// <value>
        /// Middle currency rate value
        /// </value>
        [JsonProperty("Srednji za devize")]
        public string Middle { get; set; }

        /// <summary>
        /// Selling currency rate value
        /// </summary>
        /// <value>
        /// Selling currency rate value
        /// </value>
        [JsonProperty("Prodajni za devize")]
        public string Selling { get; set; }
    }
}
