namespace AppParcial2.Models

{
    using System;
    using Newtonsoft.Json;

    public partial class Id
    {
        [JsonProperty("albumId")]
        public long AlbumId { get; set; }

        [JsonProperty("id")]
        public long IdId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }
    }
}
