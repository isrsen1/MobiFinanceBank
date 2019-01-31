using System;
using System.Collections.Generic;
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
        public DateTime ApplicationDate { get; set; }

        [JsonProperty("Država")]
        public string Country { get; set; }

        [JsonProperty("Šifra valute")]
        public int CurrencyCode { get; set; }

        [JsonProperty("Valuta")]
        public Currency Currency { get; set; }

        [JsonProperty("Jedinica")]
        public int Unit { get; set; }

        [JsonProperty("Kupovni za devize")]
        public double Buying { get; set; }

        [JsonProperty("Srednji za devize")]
        public double Middle { get; set; }

        [JsonProperty("Prodajni za devize")]
        public double Selling { get; set; }
    }
}
