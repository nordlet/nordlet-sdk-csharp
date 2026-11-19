using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeGrossReceiptsGetDeclarationsRequest
{
    [JsonPropertyName("period")]
    public required string Period { get; set; }

    [JsonPropertyName("activity")]
    public required UsDeGrossReceiptsGetDeclarationsRequestActivity Activity { get; set; }

    [JsonPropertyName("excludedReceipts")]
    public string? ExcludedReceipts { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
