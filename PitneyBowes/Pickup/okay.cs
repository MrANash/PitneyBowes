using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitneyBowes.Pickup
{
    public interface IPickupApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancel Pickup
        /// </summary>
        /// <remarks>
        /// This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="pickupId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 CancelPickup(string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = default(bool?));

        /// <summary>
        /// Cancel Pickup
        /// </summary>
        /// <remarks>
        /// This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="pickupId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> CancelPickupWithHttpInfo(string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = default(bool?));
        /// <summary>
        /// Address validation
        /// </summary>
        /// <remarks>
        /// This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="schedulePickup">Schedule Pickup request.</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>SchedulePickupResponse</returns>
        SchedulePickupResponse GetPickupschedule(string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = default(bool?));

        /// <summary>
        /// Address validation
        /// </summary>
        /// <remarks>
        /// This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="schedulePickup">Schedule Pickup request.</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>ApiResponse of SchedulePickupResponse</returns>
        ApiResponse<SchedulePickupResponse> GetPickupscheduleWithHttpInfo(string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = default(bool?));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Cancel Pickup
        /// </summary>
        /// <remarks>
        /// This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="pickupId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> CancelPickupAsync(string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = default(bool?));

        /// <summary>
        /// Cancel Pickup
        /// </summary>
        /// <remarks>
        /// This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="pickupId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> CancelPickupAsyncWithHttpInfo(string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = default(bool?));
        /// <summary>
        /// Address validation
        /// </summary>
        /// <remarks>
        /// This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="schedulePickup">Schedule Pickup request.</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>Task of SchedulePickupResponse</returns>
        System.Threading.Tasks.Task<SchedulePickupResponse> GetPickupscheduleAsync(string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = default(bool?));

        /// <summary>
        /// Address validation
        /// </summary>
        /// <remarks>
        /// This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </remarks>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="schedulePickup">Schedule Pickup request.</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>Task of ApiResponse (SchedulePickupResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchedulePickupResponse>> GetPickupscheduleAsyncWithHttpInfo(string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = default(bool?));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PickupApi : IPickupApi
    {
        private shippingapi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PickupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PickupApi(String basePath)
        {
            this.Configuration = new shippingapi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = shippingapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickupApi"/> class
        /// </summary>
        /// <returns></returns>
        public PickupApi()
        {
            this.Configuration = shippingapi.Client.Configuration.Default;

            ExceptionFactory = shippingapi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickupApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PickupApi(shippingapi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = shippingapi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = shippingapi.Client.Configuration.DefaultExceptionFactory;
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
        public shippingapi.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public shippingapi.Client.ExceptionFactory ExceptionFactory
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
        /// Cancel Pickup This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="pickupId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 CancelPickup(string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = default(bool?))
        {
            ApiResponse<InlineResponse2001> localVarResponse = CancelPickupWithHttpInfo(xPBTransactionId, pickupId, xPBUnifiedErrorStructure);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel Pickup This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="pickupId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse<InlineResponse2001> CancelPickupWithHttpInfo(string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = default(bool?))
        {
            // verify the required parameter 'xPBTransactionId' is set
            if (xPBTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'xPBTransactionId' when calling PickupApi->CancelPickup");
            // verify the required parameter 'pickupId' is set
            if (pickupId == null)
                throw new ApiException(400, "Missing required parameter 'pickupId' when calling PickupApi->CancelPickup");

            var localVarPath = "/v1/pickups/{pickupId}/cancel";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (pickupId != null) localVarPathParams.Add("pickupId", this.Configuration.ApiClient.ParameterToString(pickupId)); // path parameter
            if (xPBUnifiedErrorStructure != null) localVarHeaderParams.Add("X-PB-UnifiedErrorStructure", this.Configuration.ApiClient.ParameterToString(xPBUnifiedErrorStructure)); // header parameter
            if (xPBTransactionId != null) localVarHeaderParams.Add("X-PB-TransactionId", this.Configuration.ApiClient.ParameterToString(xPBTransactionId)); // header parameter

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelPickup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Cancel Pickup This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="pickupId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> CancelPickupAsync(string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = default(bool?))
        {
            ApiResponse<InlineResponse2001> localVarResponse = await CancelPickupAsyncWithHttpInfo(xPBTransactionId, pickupId, xPBUnifiedErrorStructure);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel Pickup This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="pickupId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> CancelPickupAsyncWithHttpInfo(string xPBTransactionId, string pickupId, bool? xPBUnifiedErrorStructure = default(bool?))
        {
            // verify the required parameter 'xPBTransactionId' is set
            if (xPBTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'xPBTransactionId' when calling PickupApi->CancelPickup");
            // verify the required parameter 'pickupId' is set
            if (pickupId == null)
                throw new ApiException(400, "Missing required parameter 'pickupId' when calling PickupApi->CancelPickup");

            var localVarPath = "/v1/pickups/{pickupId}/cancel";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (pickupId != null) localVarPathParams.Add("pickupId", this.Configuration.ApiClient.ParameterToString(pickupId)); // path parameter
            if (xPBUnifiedErrorStructure != null) localVarHeaderParams.Add("X-PB-UnifiedErrorStructure", this.Configuration.ApiClient.ParameterToString(xPBUnifiedErrorStructure)); // header parameter
            if (xPBTransactionId != null) localVarHeaderParams.Add("X-PB-TransactionId", this.Configuration.ApiClient.ParameterToString(xPBTransactionId)); // header parameter

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelPickup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Address validation This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="schedulePickup">Schedule Pickup request.</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>SchedulePickupResponse</returns>
        public SchedulePickupResponse GetPickupschedule(string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = default(bool?))
        {
            ApiResponse<SchedulePickupResponse> localVarResponse = GetPickupscheduleWithHttpInfo(xPBTransactionId, schedulePickup, xPBUnifiedErrorStructure);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Address validation This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="schedulePickup">Schedule Pickup request.</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>ApiResponse of SchedulePickupResponse</returns>
        public ApiResponse<SchedulePickupResponse> GetPickupscheduleWithHttpInfo(string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = default(bool?))
        {
            // verify the required parameter 'xPBTransactionId' is set
            if (xPBTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'xPBTransactionId' when calling PickupApi->GetPickupschedule");
            // verify the required parameter 'schedulePickup' is set
            if (schedulePickup == null)
                throw new ApiException(400, "Missing required parameter 'schedulePickup' when calling PickupApi->GetPickupschedule");

            var localVarPath = "/v1/pickups/schedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xPBUnifiedErrorStructure != null) localVarHeaderParams.Add("X-PB-UnifiedErrorStructure", this.Configuration.ApiClient.ParameterToString(xPBUnifiedErrorStructure)); // header parameter
            if (xPBTransactionId != null) localVarHeaderParams.Add("X-PB-TransactionId", this.Configuration.ApiClient.ParameterToString(xPBTransactionId)); // header parameter
            if (schedulePickup != null && schedulePickup.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(schedulePickup); // http body (model) parameter
            }
            else
            {
                localVarPostBody = schedulePickup; // byte array
            }

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPickupschedule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SchedulePickupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SchedulePickupResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchedulePickupResponse)));
        }

        /// <summary>
        /// Address validation This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="schedulePickup">Schedule Pickup request.</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>Task of SchedulePickupResponse</returns>
        public async System.Threading.Tasks.Task<SchedulePickupResponse> GetPickupscheduleAsync(string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = default(bool?))
        {
            ApiResponse<SchedulePickupResponse> localVarResponse = await GetPickupscheduleAsyncWithHttpInfo(xPBTransactionId, schedulePickup, xPBUnifiedErrorStructure);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Address validation This operation schedules a USPS package pickup from a residential or commercial location and provides a pickup confirmation number.
        /// </summary>
        /// <exception cref="shippingapi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xPBTransactionId">A unique identifier for the transaction, up to 25 characters</param>
        /// <param name="schedulePickup">Schedule Pickup request.</param>
        /// <param name="xPBUnifiedErrorStructure">Set this to true to use the standard [error object](https://shipping.pitneybowes.com/reference/error-object.html#standard-error-object) if an error occurs. (optional, default to true)</param>
        /// <returns>Task of ApiResponse (SchedulePickupResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchedulePickupResponse>> GetPickupscheduleAsyncWithHttpInfo(string xPBTransactionId, SchedulePickup schedulePickup, bool? xPBUnifiedErrorStructure = default(bool?))
        {
            // verify the required parameter 'xPBTransactionId' is set
            if (xPBTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'xPBTransactionId' when calling PickupApi->GetPickupschedule");
            // verify the required parameter 'schedulePickup' is set
            if (schedulePickup == null)
                throw new ApiException(400, "Missing required parameter 'schedulePickup' when calling PickupApi->GetPickupschedule");

            var localVarPath = "/v1/pickups/schedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xPBUnifiedErrorStructure != null) localVarHeaderParams.Add("X-PB-UnifiedErrorStructure", this.Configuration.ApiClient.ParameterToString(xPBUnifiedErrorStructure)); // header parameter
            if (xPBTransactionId != null) localVarHeaderParams.Add("X-PB-TransactionId", this.Configuration.ApiClient.ParameterToString(xPBTransactionId)); // header parameter
            if (schedulePickup != null && schedulePickup.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(schedulePickup); // http body (model) parameter
            }
            else
            {
                localVarPostBody = schedulePickup; // byte array
            }

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPickupschedule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SchedulePickupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SchedulePickupResponse)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchedulePickupResponse)));
        }
    }
}
