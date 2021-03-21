using Newtonsoft.Json;

namespace Sm.ms
{
    public class UploadImageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("file_id")]
        public int FileId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filename")]
        public string Filename { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storename")]
        public string StoreName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delete")]
        public string Delete { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }
    }
}