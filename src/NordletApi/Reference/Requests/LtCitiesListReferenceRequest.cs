using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtCitiesListReferenceRequest
{
    [JsonPropertyName("municipalityCode")]
    public string? MunicipalityCode { get; set; }

    [JsonPropertyName("q")]
    public string? Q { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
