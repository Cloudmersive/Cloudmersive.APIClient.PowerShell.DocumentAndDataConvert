/* 
 * convertapi
 *
 * Convert API lets you effortlessly convert file formats and types.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConvertDataApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// CSV to JSON conversion
        /// </summary>
        /// <remarks>
        /// Convert a CSV file to a JSON object array
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Object</returns>
        Object ConvertDataCsvToJson (System.IO.Stream inputFile);

        /// <summary>
        /// CSV to JSON conversion
        /// </summary>
        /// <remarks>
        /// Convert a CSV file to a JSON object array
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ConvertDataCsvToJsonWithHttpInfo (System.IO.Stream inputFile);
        /// <summary>
        /// XML to JSON conversion
        /// </summary>
        /// <remarks>
        /// Convert an XML string or file into JSON
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Object</returns>
        Object ConvertDataXmlToJson (System.IO.Stream inputFile);

        /// <summary>
        /// XML to JSON conversion
        /// </summary>
        /// <remarks>
        /// Convert an XML string or file into JSON
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ConvertDataXmlToJsonWithHttpInfo (System.IO.Stream inputFile);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// CSV to JSON conversion
        /// </summary>
        /// <remarks>
        /// Convert a CSV file to a JSON object array
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ConvertDataCsvToJsonAsync (System.IO.Stream inputFile);

        /// <summary>
        /// CSV to JSON conversion
        /// </summary>
        /// <remarks>
        /// Convert a CSV file to a JSON object array
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConvertDataCsvToJsonAsyncWithHttpInfo (System.IO.Stream inputFile);
        /// <summary>
        /// XML to JSON conversion
        /// </summary>
        /// <remarks>
        /// Convert an XML string or file into JSON
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ConvertDataXmlToJsonAsync (System.IO.Stream inputFile);

        /// <summary>
        /// XML to JSON conversion
        /// </summary>
        /// <remarks>
        /// Convert an XML string or file into JSON
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConvertDataXmlToJsonAsyncWithHttpInfo (System.IO.Stream inputFile);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConvertDataApi : IConvertDataApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConvertDataApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConvertDataApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// CSV to JSON conversion Convert a CSV file to a JSON object array
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Object</returns>
        public Object ConvertDataCsvToJson (System.IO.Stream inputFile)
        {
             ApiResponse<Object> localVarResponse = ConvertDataCsvToJsonWithHttpInfo(inputFile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// CSV to JSON conversion Convert a CSV file to a JSON object array
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ConvertDataCsvToJsonWithHttpInfo (System.IO.Stream inputFile)
        {
            // verify the required parameter 'inputFile' is set
            if (inputFile == null)
                throw new ApiException(400, "Missing required parameter 'inputFile' when calling ConvertDataApi->ConvertDataCsvToJson");

            var localVarPath = "/convert/csv/to/json";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile != null) localVarFileParams.Add("inputFile", Configuration.ApiClient.ParameterToFile("inputFile", inputFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConvertDataCsvToJson", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// CSV to JSON conversion Convert a CSV file to a JSON object array
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ConvertDataCsvToJsonAsync (System.IO.Stream inputFile)
        {
             ApiResponse<Object> localVarResponse = await ConvertDataCsvToJsonAsyncWithHttpInfo(inputFile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// CSV to JSON conversion Convert a CSV file to a JSON object array
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConvertDataCsvToJsonAsyncWithHttpInfo (System.IO.Stream inputFile)
        {
            // verify the required parameter 'inputFile' is set
            if (inputFile == null)
                throw new ApiException(400, "Missing required parameter 'inputFile' when calling ConvertDataApi->ConvertDataCsvToJson");

            var localVarPath = "/convert/csv/to/json";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile != null) localVarFileParams.Add("inputFile", Configuration.ApiClient.ParameterToFile("inputFile", inputFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConvertDataCsvToJson", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// XML to JSON conversion Convert an XML string or file into JSON
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Object</returns>
        public Object ConvertDataXmlToJson (System.IO.Stream inputFile)
        {
             ApiResponse<Object> localVarResponse = ConvertDataXmlToJsonWithHttpInfo(inputFile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// XML to JSON conversion Convert an XML string or file into JSON
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ConvertDataXmlToJsonWithHttpInfo (System.IO.Stream inputFile)
        {
            // verify the required parameter 'inputFile' is set
            if (inputFile == null)
                throw new ApiException(400, "Missing required parameter 'inputFile' when calling ConvertDataApi->ConvertDataXmlToJson");

            var localVarPath = "/convert/xml/to/json";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile != null) localVarFileParams.Add("inputFile", Configuration.ApiClient.ParameterToFile("inputFile", inputFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConvertDataXmlToJson", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// XML to JSON conversion Convert an XML string or file into JSON
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ConvertDataXmlToJsonAsync (System.IO.Stream inputFile)
        {
             ApiResponse<Object> localVarResponse = await ConvertDataXmlToJsonAsyncWithHttpInfo(inputFile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// XML to JSON conversion Convert an XML string or file into JSON
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConvertDataXmlToJsonAsyncWithHttpInfo (System.IO.Stream inputFile)
        {
            // verify the required parameter 'inputFile' is set
            if (inputFile == null)
                throw new ApiException(400, "Missing required parameter 'inputFile' when calling ConvertDataApi->ConvertDataXmlToJson");

            var localVarPath = "/convert/xml/to/json";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile != null) localVarFileParams.Add("inputFile", Configuration.ApiClient.ParameterToFile("inputFile", inputFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ConvertDataXmlToJson", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}
