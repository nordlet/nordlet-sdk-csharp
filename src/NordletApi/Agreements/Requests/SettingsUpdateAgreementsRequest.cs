using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettingsUpdateAgreementsRequest
{
    [JsonPropertyName("autoBilling")]
    public required bool AutoBilling { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
