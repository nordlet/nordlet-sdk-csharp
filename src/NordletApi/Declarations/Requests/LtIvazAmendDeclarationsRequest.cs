using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtIvazAmendDeclarationsRequest
{
    [JsonPropertyName("waybillIds")]
    public IEnumerable<string> WaybillIds { get; set; } = new List<string>();

    [JsonPropertyName("persist")]
    public bool? Persist { get; set; }

    [JsonPropertyName("corrections")]
    public IEnumerable<LtIvazAmendDeclarationsRequestCorrectionsItem>? Corrections { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
