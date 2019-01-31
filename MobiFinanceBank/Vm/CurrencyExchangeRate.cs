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
    public class CurrencyExchangeRate
    {
        [JsonProperty("Broj tečajnice")]
        public string ExchangeRateList { get; set; }

        [JsonProperty("Datum primjene")]
        public string ApplicationDate { get; set; }

        [JsonProperty("Država")]
        public string Country { get; set; }

        [JsonProperty("Šifra valute")]
        public string CurrencyCode { get; set; }

        [JsonProperty("Valuta")]
        public string Currency { get; set; }

        [JsonProperty("Jedinica")]
        public int Unit { get; set; }

        [JsonProperty("Kupovni za devize")]
        public string Buying { get; set; }

        [JsonProperty("Srednji za devize")]
        public string Middle { get; set; }

        [JsonProperty("Prodajni za devize")]
        public string Selling { get; set; }
    }
}
