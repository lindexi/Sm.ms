using Newtonsoft.Json;

namespace Sm.ms
{
    public class SmmsResponseBase<T>
    {
        /// <summary>
        /// Request status.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Request status code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The Data
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }

        /// <summary>
        /// Request ID.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId { get; set; }
    }
}