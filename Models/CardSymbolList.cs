// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Scryfall.API.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CardSymbolList
    {
        /// <summary>
        /// Initializes a new instance of the CardSymbolList class.
        /// </summary>
        public CardSymbolList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CardSymbolList class.
        /// </summary>
        public CardSymbolList(IList<CardSymbol> data = default(IList<CardSymbol>))
        {
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<CardSymbol> Data { get; set; }

    }
}
