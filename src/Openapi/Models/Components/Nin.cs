//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi.Models.Components
{
    using Newtonsoft.Json;
    using Openapi.Utils;
    
    /// <summary>
    /// The subject&apos;s National Identity Number information.
    /// </summary>
    public class Nin
    {

        /// <summary>
        /// Gets the Value from NIN.
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; } = null;

        /// <summary>
        /// Gets the IssuingCountry from NIN.
        /// </summary>
        [JsonProperty("issuingCountry")]
        public string? IssuingCountry { get; set; } = null;

        /// <summary>
        /// Gets the Type from NIN.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; } = null;
    }
}