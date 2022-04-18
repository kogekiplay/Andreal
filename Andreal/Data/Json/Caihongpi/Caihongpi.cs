using Newtonsoft.Json;

#pragma warning disable CS8618

namespace Andreal.Data.Json.Caihongpi;

[Serializable]
public class Caihongpi
{
    [JsonProperty("data")] public Caihongpiresponse data { get; set; }
}