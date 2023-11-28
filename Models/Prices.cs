using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatMTG.Scryfall.Models
{
    public partial class Prices
    {
        public Prices()
        {
            CustomInit();
        }

        public Prices(string usd = default(string), string usd_etched = default(string), string usdFoil = default(string), string eur_foil = default(string), string eur = default(string), string tix = default(string))
        {
            Usd = usd;
            UsdFoil = usdFoil;
            Eur = eur;
            Tix = tix;
            CustomInit();
        }

        partial void CustomInit();
        [JsonProperty(PropertyName = "usd")]
        public string Usd { get; set; }
        [JsonProperty(PropertyName = "usd_foil")]
        public string UsdFoil { get; set; }
        [JsonProperty(PropertyName = "usd_etched")]
        public string Usd_Etched { get; set; }
        [JsonProperty(PropertyName = "eur")]
        public string Eur { get; set; }
        [JsonProperty(PropertyName = "eur_foil")]
        public string EurFoil { get; set; }
        [JsonProperty(PropertyName = "tix")]
        public string Tix { get; set; }


    }
}
