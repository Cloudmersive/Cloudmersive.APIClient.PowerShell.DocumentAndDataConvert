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
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConvertWebApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Convert HTML string to PDF
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PDF of the HTML.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">HTML to PDF request parameters</param>
        /// <returns>Object</returns>
        Object ConvertWebHtmlToPdf (HtmlToPdfRequest input);

        /// <summary>
        /// Convert HTML string to PDF
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PDF of the HTML.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">HTML to PDF request parameters</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ConvertWebHtmlToPdfWithHttpInfo (HtmlToPdfRequest input);
        /// <summary>
        /// Convert a URL to PDF
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PDF of the full page.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">URL to PDF request parameters</param>
        /// <returns>Object</returns>
        Object ConvertWebUrlToPdf (ScreenshotRequest input);

        /// <summary>
        /// Convert a URL to PDF
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PDF of the full page.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">URL to PDF request parameters</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ConvertWebUrlToPdfWithHttpInfo (ScreenshotRequest input);
        /// <summary>
        /// Take screenshot of URL
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PNG screenshot of the full page image.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Screenshot request parameters</param>
        /// <returns>Object</returns>
        Object ConvertWebUrlToScreenshot (ScreenshotRequest input);

        /// <summary>
        /// Take screenshot of URL
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PNG screenshot of the full page image.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Screenshot request parameters</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ConvertWebUrlToScreenshotWithHttpInfo (ScreenshotRequest input);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Convert HTML string to PDF
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PDF of the HTML.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">HTML to PDF request parameters</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ConvertWebHtmlToPdfAsync (HtmlToPdfRequest input);

        /// <summary>
        /// Convert HTML string to PDF
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PDF of the HTML.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">HTML to PDF request parameters</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConvertWebHtmlToPdfAsyncWithHttpInfo (HtmlToPdfRequest input);
        /// <summary>
        /// Convert a URL to PDF
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PDF of the full page.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">URL to PDF request parameters</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ConvertWebUrlToPdfAsync (ScreenshotRequest input);

        /// <summary>
        /// Convert a URL to PDF
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PDF of the full page.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">URL to PDF request parameters</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConvertWebUrlToPdfAsyncWithHttpInfo (ScreenshotRequest input);
        /// <summary>
        /// Take screenshot of URL
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PNG screenshot of the full page image.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Screenshot request parameters</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ConvertWebUrlToScreenshotAsync (ScreenshotRequest input);

        /// <summary>
        /// Take screenshot of URL
        /// </summary>
        /// <remarks>
        /// Fully renders a website and returns a PNG screenshot of the full page image.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Screenshot request parameters</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConvertWebUrlToScreenshotAsyncWithHttpInfo (ScreenshotRequest input);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConvertWebApi : IConvertWebApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertWebApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConvertWebApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertWebApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConvertWebApi(Configuration configuration = null)
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
        /// Convert HTML string to PDF Fully renders a website and returns a PDF of the HTML.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">HTML to PDF request parameters</param>
        /// <returns>Object</returns>
        public Object ConvertWebHtmlToPdf (HtmlToPdfRequest input)
        {
             ApiResponse<Object> localVarResponse = ConvertWebHtmlToPdfWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Convert HTML string to PDF Fully renders a website and returns a PDF of the HTML.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">HTML to PDF request parameters</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ConvertWebHtmlToPdfWithHttpInfo (HtmlToPdfRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ConvertWebApi->ConvertWebHtmlToPdf");

            var localVarPath = "/convert/web/html/to/pdf";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

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
                Exception exception = ExceptionFactory("ConvertWebHtmlToPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Convert HTML string to PDF Fully renders a website and returns a PDF of the HTML.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">HTML to PDF request parameters</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ConvertWebHtmlToPdfAsync (HtmlToPdfRequest input)
        {
             ApiResponse<Object> localVarResponse = await ConvertWebHtmlToPdfAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Convert HTML string to PDF Fully renders a website and returns a PDF of the HTML.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">HTML to PDF request parameters</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConvertWebHtmlToPdfAsyncWithHttpInfo (HtmlToPdfRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ConvertWebApi->ConvertWebHtmlToPdf");

            var localVarPath = "/convert/web/html/to/pdf";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

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
                Exception exception = ExceptionFactory("ConvertWebHtmlToPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Convert a URL to PDF Fully renders a website and returns a PDF of the full page.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">URL to PDF request parameters</param>
        /// <returns>Object</returns>
        public Object ConvertWebUrlToPdf (ScreenshotRequest input)
        {
             ApiResponse<Object> localVarResponse = ConvertWebUrlToPdfWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Convert a URL to PDF Fully renders a website and returns a PDF of the full page.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">URL to PDF request parameters</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ConvertWebUrlToPdfWithHttpInfo (ScreenshotRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ConvertWebApi->ConvertWebUrlToPdf");

            var localVarPath = "/convert/web/url/to/pdf";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

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
                Exception exception = ExceptionFactory("ConvertWebUrlToPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Convert a URL to PDF Fully renders a website and returns a PDF of the full page.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">URL to PDF request parameters</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ConvertWebUrlToPdfAsync (ScreenshotRequest input)
        {
             ApiResponse<Object> localVarResponse = await ConvertWebUrlToPdfAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Convert a URL to PDF Fully renders a website and returns a PDF of the full page.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">URL to PDF request parameters</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConvertWebUrlToPdfAsyncWithHttpInfo (ScreenshotRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ConvertWebApi->ConvertWebUrlToPdf");

            var localVarPath = "/convert/web/url/to/pdf";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

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
                Exception exception = ExceptionFactory("ConvertWebUrlToPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Take screenshot of URL Fully renders a website and returns a PNG screenshot of the full page image.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Screenshot request parameters</param>
        /// <returns>Object</returns>
        public Object ConvertWebUrlToScreenshot (ScreenshotRequest input)
        {
             ApiResponse<Object> localVarResponse = ConvertWebUrlToScreenshotWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Take screenshot of URL Fully renders a website and returns a PNG screenshot of the full page image.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Screenshot request parameters</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ConvertWebUrlToScreenshotWithHttpInfo (ScreenshotRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ConvertWebApi->ConvertWebUrlToScreenshot");

            var localVarPath = "/convert/web/url/to/screenshot";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

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
                Exception exception = ExceptionFactory("ConvertWebUrlToScreenshot", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Take screenshot of URL Fully renders a website and returns a PNG screenshot of the full page image.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Screenshot request parameters</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ConvertWebUrlToScreenshotAsync (ScreenshotRequest input)
        {
             ApiResponse<Object> localVarResponse = await ConvertWebUrlToScreenshotAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Take screenshot of URL Fully renders a website and returns a PNG screenshot of the full page image.  Javascript, HTML5, CSS and other advanced features are all supported.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Screenshot request parameters</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConvertWebUrlToScreenshotAsyncWithHttpInfo (ScreenshotRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ConvertWebApi->ConvertWebUrlToScreenshot");

            var localVarPath = "/convert/web/url/to/screenshot";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

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
                Exception exception = ExceptionFactory("ConvertWebUrlToScreenshot", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}