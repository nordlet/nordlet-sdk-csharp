using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsSubmissionsCreateRequest
{
    [JsonPropertyName("obligation")]
    public required PostV1DeclarationsSubmissionsCreateRequestObligation Obligation { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("dataType")]
    public PostV1DeclarationsSubmissionsCreateRequestDataType? DataType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
