using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class channels
{
    [JsonProperty("rgbChannels")]
    public int rgbChannels { get; set; }

    [JsonProperty("cmykChannels")]
    public int cmykChannels { get; set; }

    [JsonProperty("ansiChannels")]
    public int ansiChannels { get; set; }

    [JsonProperty("hexChannels")]
    public int hexChannels { get; set; }

    [JsonProperty("hslChannels")]
    public int hslChannels { get; set; }

}

public class data
{
    [JsonProperty("hex")]
    public string hex { get; set; }

    [JsonProperty("rgb")]
    public string rgb { get; set; }

    [JsonProperty("hsl")]
    public string hsl { get; set; }

    [JsonProperty("cmyk")]
    public string cmyk { get; set; }

    [JsonProperty("ansi16")]
    public int ansi16 { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("channels")]
    public channels channels { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
