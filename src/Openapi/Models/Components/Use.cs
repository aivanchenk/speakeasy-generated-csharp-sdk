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
    /// Identifies the intended use of the key. Values defined by this specification are sig (signature) and enc (encryption).
    /// </summary>
    public enum Use
    {
        [JsonProperty("enc")]
        Enc,
    }

    public static class UseExtension
    {
        public static string Value(this Use value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Use ToEnum(this string value)
        {
            foreach(var field in typeof(Use).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is Use)
                    {
                        return (Use)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Use");
        }
    }

}