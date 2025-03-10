//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi
{
    using Newtonsoft.Json;
    using Openapi.Hooks;
    using Openapi.Models.Errors;
    using Openapi.Utils;
    using Openapi.Utils.Retries;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Signicat Authentication REST API: Signicat&apos;s Authentication REST API allows you to interact with the Signicat <a href="https://developer.signicat.com/docs/eid-hub/">eID Hub</a>. Our digital solutions enable identity verification and authentication through a wide selection of electronic <a href="https://developer.signicat.com/identity-methods/">ID methods</a>. <br/>
    /// 
    /// <remarks>
    ///  The Authentication REST API is a REST API with all request and response bodies formatted in JSON. <br/>
    ///  # Authorisation<br/>
    ///  For more information on how to access the Authentication REST API, see the <a href="https://developer.signicat.com/docs/accessing-api-products.html">Accessing Signicat API products</a> guide in our developer documentation.
    /// </remarks>
    /// </summary>
    public interface ISignicat
    {
        public IAuthenticationSession AuthenticationSession { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.signicat.com/auth/rest",
        };

        public string ServerUrl = "";
        public int ServerIndex = 0;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], new Dictionary<string, string>());
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Signicat Authentication REST API: Signicat&apos;s Authentication REST API allows you to interact with the Signicat <a href="https://developer.signicat.com/docs/eid-hub/">eID Hub</a>. Our digital solutions enable identity verification and authentication through a wide selection of electronic <a href="https://developer.signicat.com/identity-methods/">ID methods</a>. <br/>
    /// 
    /// <remarks>
    ///  The Authentication REST API is a REST API with all request and response bodies formatted in JSON. <br/>
    ///  # Authorisation<br/>
    ///  For more information on how to access the Authentication REST API, see the <a href="https://developer.signicat.com/docs/accessing-api-products.html">Accessing Signicat API products</a> guide in our developer documentation.
    /// </remarks>
    /// </summary>
    public class Signicat: ISignicat
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "2.541.0";
        private const string _openapiDocVersion = "v1";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.1 2.541.0 v1 Openapi";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        public IAuthenticationSession AuthenticationSession { get; private set; }

        public Signicat(int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _client = client ?? new SpeakeasyHttpClient();

            SDKConfiguration = new SDKConfig()
            {
                ServerIndex = _serverIndex,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _client = SDKConfiguration.InitHooks(_client);


            AuthenticationSession = new AuthenticationSession(_client, _serverUrl, SDKConfiguration);
        }
    }
}