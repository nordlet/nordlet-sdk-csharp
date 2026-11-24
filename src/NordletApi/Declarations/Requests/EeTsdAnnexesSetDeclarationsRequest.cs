using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesSetDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("annex4")]
    public EeTsdAnnexesSetDeclarationsRequestAnnex4? Annex4 { get; set; }

    [JsonPropertyName("annex5")]
    public EeTsdAnnexesSetDeclarationsRequestAnnex5? Annex5 { get; set; }

    [JsonPropertyName("annex6")]
    public EeTsdAnnexesSetDeclarationsRequestAnnex6? Annex6 { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
