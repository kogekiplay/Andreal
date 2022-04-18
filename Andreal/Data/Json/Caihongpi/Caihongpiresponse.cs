using Newtonsoft.Json;

#pragma warning disable CS8618

namespace Andreal.Data.Json.Caihongpi;

[Serializable]
public class Caihongpiresponse
{
    [JsonProperty("comment")] public string comment { get; set; }
}