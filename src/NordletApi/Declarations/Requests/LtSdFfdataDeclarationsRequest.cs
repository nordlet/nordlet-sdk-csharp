using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtSdFfdataDeclarationsRequest
{
    [JsonPropertyName("type")]
    public required LtSdFfdataDeclarationsRequestType Type { get; set; }

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("managerFullName")]
    public string? ManagerFullName { get; set; }

    [JsonPropertyName("preparatorDetails")]
    public string? PreparatorDetails { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
