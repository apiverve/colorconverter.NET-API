using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Channels data
    /// </summary>
    public class Channels
    {
        [JsonProperty("rgbChannels")]
        public int RgbChannels { get; set; }

        [JsonProperty("cmykChannels")]
        public int CmykChannels { get; set; }

        [JsonProperty("ansiChannels")]
        public int AnsiChannels { get; set; }

        [JsonProperty("hexChannels")]
        public int HexChannels { get; set; }

        [JsonProperty("hslChannels")]
        public int HslChannels { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("hsl")]
        public string Hsl { get; set; }

        [JsonProperty("cmyk")]
        public string Cmyk { get; set; }

        [JsonProperty("ansi16")]
        public int Ansi16 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("channels")]
        public Channels Channels { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
