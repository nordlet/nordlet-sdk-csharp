using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtSaftSendDeclarationsRequest
{
    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("dataType")]
    public LtSaftSendDeclarationsRequestDataType? DataType { get; set; }

    [JsonPropertyName("confirm")]
    public bool? Confirm { get; set; }

    [JsonPropertyName("amend")]
    public bool? Amend { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
