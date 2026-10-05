using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettingsUpdateInventoryRequest
{
    [JsonPropertyName("negativeStockPolicy")]
    public required SettingsUpdateInventoryRequestNegativeStockPolicy NegativeStockPolicy { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
