// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */



using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Provides a non-generic contract for the ApiResponse wrapper.
    /// </summary>
    public interface IApiResponse
    {
        /// <summary>
        /// The data type of <see cref="Data"/>
        /// </summary>
        Type ResponseType { get; }

        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw content of this response
        /// </summary>
        string RawContent { get; }
    }

    /// <summary>
    /// API Response
    /// </summary>
    public partial class ApiResponse<T> : IApiResponse
    {
        #region Properties

        /// <summary>
        /// The deserialized content
        /// </summary>
        public T Content { get; set; }

        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The content of this response
        /// </summary>
        public Type ResponseType
        {
            get { return typeof(T); }
        }

        /// <summary>
        /// The raw data
        /// </summary>
        public string RawContent { get; }

        /// <summary>
        /// The IsSuccessStatusCode from the api response
        /// </summary>
        public bool IsSuccessStatusCode { get; }

        /// <summary>
        /// The reason phrase contained in the api response
        /// </summary>
        public string ReasonPhrase { get; }

        /// <summary>
        /// The headers contained in the api response
        /// </summary>
        public System.Net.Http.Headers.HttpResponseHeaders Headers { get; }

        #endregion Properties

        /// <summary>
        /// Construct the reponse using an HttpResponseMessage
        /// </summary>
        /// <param name="response"></param>
        /// <param name="rawContent"></param>
        public ApiResponse(System.Net.Http.HttpResponseMessage response, string rawContent)
        {
            StatusCode = response.StatusCode;
            Headers = response.Headers;
            IsSuccessStatusCode = response.IsSuccessStatusCode;
            ReasonPhrase = response.ReasonPhrase;
            RawContent = rawContent;
        }
    }
}
