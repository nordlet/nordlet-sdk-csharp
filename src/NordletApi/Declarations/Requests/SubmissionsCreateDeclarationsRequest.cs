using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SubmissionsCreateDeclarationsRequest
{
    [JsonPropertyName("obligation")]
    public required SubmissionsCreateDeclarationsRequestObligation Obligation { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("dataType")]
    public SubmissionsCreateDeclarationsRequestDataType? DataType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
