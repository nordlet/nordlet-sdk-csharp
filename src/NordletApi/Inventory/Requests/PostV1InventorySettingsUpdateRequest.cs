using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1InventorySettingsUpdateRequest
{
    [JsonPropertyName("negativeStockPolicy")]
    public required PostV1InventorySettingsUpdateRequestNegativeStockPolicy NegativeStockPolicy { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
