using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class articles
{
    [JsonProperty("category")]
    public string category { get; set; }

    [JsonProperty("website")]
    public string website { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("pubDate")]
    public string pubDate { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

    [JsonProperty("link")]
    public string link { get; set; }

}

public class data
{
    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("category")]
    public string category { get; set; }

    [JsonProperty("articleCount")]
    public int articleCount { get; set; }

    [JsonProperty("articles")]
    public articles[] articles { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
