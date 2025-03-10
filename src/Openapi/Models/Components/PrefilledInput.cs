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
    using System;
    
    /// <summary>
    /// The session&apos;s prefilled input information (it is required at least one value).
    /// </summary>
    public class PrefilledInput
    {

        /// <summary>
        /// The National Identity Number of the prefilled input.
        /// </summary>
        [JsonProperty("nin")]
        public string? Nin { get; set; } = null;

        /// <summary>
        /// The mobile number of the prefilled input.
        /// </summary>
        [JsonProperty("mobile")]
        public string? Mobile { get; set; } = null;

        /// <summary>
        /// The email of the prefilled input.
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; } = null;

        /// <summary>
        /// The user name of the prefilled input.
        /// </summary>
        [JsonProperty("userName")]
        public string? UserName { get; set; } = null;

        /// <summary>
        /// The date of birth of the prefilled input.
        /// </summary>
        [JsonProperty("dateOfBirth")]
        public DateTime? DateOfBirth { get; set; } = null;

        /// <summary>
        /// The device ID.
        /// </summary>
        [JsonProperty("deviceId")]
        public string? DeviceId { get; set; } = null;

        /// <summary>
        /// The first name of the prefilled input.
        /// </summary>
        [JsonProperty("firstName")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// The last name of the prefilled input.
        /// </summary>
        [JsonProperty("lastName")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// The bank account number of the prefilled input.
        /// </summary>
        [JsonProperty("bankAccountNumber")]
        public string? BankAccountNumber { get; set; } = null;

        /// <summary>
        /// The organisation of the prefilled input.
        /// </summary>
        [JsonProperty("organisation")]
        public string? Organisation { get; set; } = null;
    }
}