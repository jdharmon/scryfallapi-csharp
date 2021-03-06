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

    public partial class Catalog
    {
        /// <summary>
        /// Initializes a new instance of the Catalog class.
        /// </summary>
        public Catalog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Catalog class.
        /// </summary>
        public Catalog(int? totalItems = default(int?), IList<string> data = default(IList<string>))
        {
            TotalItems = totalItems;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total_items")]
        public int? TotalItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<string> Data { get; set; }

    }
}
