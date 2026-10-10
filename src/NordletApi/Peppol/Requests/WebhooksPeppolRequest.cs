using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record WebhooksPeppolRequest
{
    [JsonIgnore]
    public required WebhooksPeppolRequestProvider Provider { get; set; }

    [JsonIgnore]
    public required string CompanyId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
